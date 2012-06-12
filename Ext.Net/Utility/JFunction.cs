/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [Description("")]
    public partial class JFunction : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction(string handler)
        {
            this.Handler = handler;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JFunction(string handler, params string[] args) 
        {
            this.Handler = handler;
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
                return this.NamePrefix + this.Fn;
            }

            string handler = TokenUtils.ReplaceRawToken(TokenUtils.ParseTokens(this.Handler, this.Owner));

            if (this.Args != null && this.Args.Length > 0)
            {
                if (this.FormatHandler)
                {
                    return this.NamePrefix + "function(".ConcatWith(this.Args.Join(","), "){", handler.FormatWith(this.Args), "}");
                }
                else
                {
                    return this.NamePrefix + "function(".ConcatWith(this.Args.Join(","), "){", handler, "}");
                }
            }
            else
            {
                return this.NamePrefix + "function(){".ConcatWith(handler).ConcatWith("}");
            }
        }

        private string NamePrefix
        {
            get
            {
                return this.Name.IsEmpty() ? "" : this.Name + ":";
            }
        }

        private string name;

		/// <summary>
		/// 
		/// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
		[Description("")]
        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }


        private string fn;

        /// <summary>
        /// The raw JavaScript code to call.
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("The raw JavaScript code to call.")]
        public virtual string Fn
        {
            get 
            { 
                return this.fn; 
            }
            set 
            {
                this.fn = value; 
            }
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

        string[] args;

        /// <summary>
        /// Custom arguments passed to event handler if Handler property is set.
        /// </summary>
        [TypeConverter(typeof(StringArrayConverter))]
        [NotifyParentProperty(true)]
        [DefaultValue(null)]
        [Description("Custom arguments passed to event handler if Handler property is set.")]
        public virtual string[] Args
        {
            get
            {
                return this.args;
            }
            set
            {
                this.args = value;
            }
        }

        private bool formatHandler = false;

        /// <summary>
        /// If FormatHander=true, then the Handler property will be passed through the string.Format() Method and argument placeholders/tokens with be replaced with the argument index value.
        /// </summary>
        [NotifyParentProperty(true)]
        [DefaultValue(false)]
        [Description("If FormatHander=true, then the Handler property will be passed through the string.Format() Method and argument placeholders/tokens with be replaced with the argument index value.")]
        public virtual bool FormatHandler
        {
            get
            {
                return this.formatHandler;
            }
            set
            {
                this.formatHandler = value;
            }
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
                JFunction fn = new JFunction();
                fn.Fn = "Ext.emptyFn";

                return fn;
            }
        }
    }
}