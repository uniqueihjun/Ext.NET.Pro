/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [Description("")]
    public partial class JFunction : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction() { }

        private static readonly Regex Value_RE = new Regex(@"^([\w\.]+)$", RegexOptions.Compiled);
        private static readonly Regex Fn_RE = new Regex(@"^function\s*\(", RegexOptions.Compiled);

        ///<summary>
        /// Return true if passed string is function name (otherwise it is handler)
        ///</summary>
        ///<param name="fn"></param>
        ///<returns></returns>
        public static bool IsFunctionName(string fn)
        {
            if (fn == null)
            {
                throw new ArgumentNullException("fn");
            }

            return Value_RE.Match(fn).Success || Fn_RE.Match(fn).Success;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction(string handler)
		{
            if (handler == null)
            {
                throw new ArgumentNullException("handler");
            }

            if (JFunction.IsFunctionName(handler))
            {
                this.Fn = handler;
            }
            else
            {
                this.Handler = handler;
            }
		        
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="delay"></param>
        public JFunction(string handler, int delay) : this(handler)
        {
            this.Delay = delay;
        }

        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction(string handler, params string[] args) : this(handler)
        {            
            this.Args = args;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.ToScript();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public virtual string ToScript()
        {
            if (this.Fn.IsNotEmpty())
            {
                return this.WrapByDelay(this.NamePrefix + this.Fn);
            }

            string handler = TokenUtils.ReplaceRawToken(TokenUtils.ParseTokens(this.Handler, this.Owner));

            if (this.Args != null && this.Args.Length > 0)
            {
                if (this.FormatHandler)
                {
                    return this.WrapByDelay(this.NamePrefix + "function(".ConcatWith(this.Args.Join(","), "){", handler.FormatWith(this.Args), "}"));
                }
                
                return this.WrapByDelay(this.NamePrefix + "function(".ConcatWith(this.Args.Join(","), "){", handler, "}"));
            }

            return this.WrapByDelay(this.NamePrefix + "function(){".ConcatWith(handler).ConcatWith("}"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fn"></param>
        /// <returns></returns>
        protected virtual string WrapByDelay(string fn) 
        {
            if (this.Delay > 0)
            {
                return "Ext.Function.createDelayed({0}, {1})".FormatWith(fn, this.Delay);
            }

            return fn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public virtual string ToCallScript(params string[] args) 
        {
            StringBuilder sb = new StringBuilder();

            if (args != null && args.Length > 0)
            {
                foreach (object arg in args)
                {
                    sb.AppendFormat("{0},", JSON.Serialize(arg, JSON.ScriptConvertersInternal));
                }
            }

            return "({0}).({1});".FormatWith(this.ToScript(), sb.ToString().LeftOfRightmostOf(','));
        }

        private string NamePrefix
        {
            get
            {
                return this.Name.IsEmpty() ? "" : this.Name + ":";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
		[Description("")]
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The raw JavaScript code to call.
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("The raw JavaScript code to call.")]
        public virtual string Fn
        {
            get;
            set;
        }

        string handler = "";

        /// <summary>
        /// The JavaScript logic within the function(){} signature.
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue("")]
        [Description("The JavaScript logic within the function(){} signature.")]
        public virtual string Handler
        {
            get
            {
                return this.handler;
            }
            set
            {
                this.handler = value;
            }
        }

        /// <summary>
        /// Custom arguments passed to event handler if Handler property is set.
        /// </summary>
        [TypeConverter(typeof(StringArrayConverter))]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("Custom arguments passed to event handler if Handler property is set.")]
        public virtual string[] Args
        {
            get;
            set;
        }

        /// <summary>
        /// If FormatHander=true, then the Handler property will be passed through the string.Format() Method and argument placeholders/tokens with be replaced with the argument index value.
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(false)]
        [Description("If FormatHander=true, then the Handler property will be passed through the string.Format() Method and argument placeholders/tokens with be replaced with the argument index value.")]
        public virtual bool FormatHandler
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public virtual int Delay
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Handler.IsEmpty() && this.Fn.IsEmpty();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static JFunction EmptyFn
        {
            get
            {
                return new JFunction {Fn = "Ext.emptyFn"};
            }
        }
    }
}