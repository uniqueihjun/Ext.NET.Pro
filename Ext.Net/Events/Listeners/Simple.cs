/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SimpleListener : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SimpleListener() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SimpleListener(string handler)
        {
            this.Handler = handler;
        }

        private string FnInternal
        {
            get
            {
                string handler = this.Handler;

                if (this.Fn.IsEmpty() && handler.IsNotEmpty())
                {
                    string parsedHandler = TokenUtils.ParseTokens(handler, this.Owner);

                    if (TokenUtils.IsRawToken(parsedHandler))
                    {
                        string temp = TokenUtils.ReplaceRawToken(parsedHandler);

                        if (!temp.StartsWith("Ext."))
                        {
                            return temp;
                        }
                    }

                    return string.Format(ResourceManager.FunctionTemplateWithParams, this.ArgumentList.Join(), TokenUtils.ReplaceRawToken(parsedHandler));
                }

                return (this.Fn.IsEmpty()) ? "" : TokenUtils.ReplaceRawToken(TokenUtils.ParseTokens(this.Fn, this.Owner));
            }
        }

        /// <summary>
        /// The raw JavaScript function to be called when this Listener fires.
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The raw JavaScript function to be called when this Listener fires.")]
        public virtual string Fn
        {
            get
            {
                return (string)this.ViewState["Fn"] ?? "";
            }
            set
            {
                this.ViewState["Fn"] = value;
            }
        }

        /// <summary>
        /// The JavaScript logic to be called when this Listener fires. The Handler will be automatically wrapped in a proper function(){} template and passed the correct arguments for this event.
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The JavaScript logic to be called when this Listener fires. The Handler will be automatically wrapped in a proper function(){} template and passed the correct arguments for this event.")]
        public virtual string Handler
        {
            get
            {
                return (string)this.ViewState["Handler"] ?? "";
            }
            set
            {
                this.ViewState["Handler"] = value;
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
                return this.FnInternal.IsEmpty();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.FnInternal;
        }

        List<string> argumentList;

        /// <summary>
        /// List of Arguments passed to event handler.
        /// </summary>
        [Description("List of Arguments passed to event handler.")]
        internal List<string> ArgumentList
        {
            get
            {
                if (this.argumentList == null)
                {
                    this.argumentList = new List<string>();
                }

                return this.argumentList;
            }
        }
    }
}