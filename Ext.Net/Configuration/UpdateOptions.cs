/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class UpdateOptions : StateManagedItem
    {
        /// <summary>
        /// The URL to request or a function which returns the URL.
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The URL to request or a function which returns the URL.")]
        public virtual string Url
        {
            get
            {
                return (string)this.ViewState["Url"] ?? "";
            }
            set
            {
                this.ViewState["Url"] = value;
            }
        }

        /// <summary>
        /// The HTTP method to use. Defaults to POST if params are present, or GET if not.
        /// </summary>
        [ConfigOption]
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("The HTTP method to use. Defaults to POST if params are present, or GET if not.")]
        public virtual HttpMethod Method
        {
            get
            {
                object obj = this.ViewState["Method"];
                return (obj == null) ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["Method"] = value;
            }
        }

        /// <summary>
        /// The parameters to pass to the server.
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("The parameters to pass to the server.")]
        public virtual string Params
        {
            get
            {
                return (string)this.ViewState["Params"] ?? "";
            }
            set
            {
                this.ViewState["Params"] = value;
            }
        }

        /// <summary>
        /// If true any &lt;script> tags embedded in the response text will be extracted and executed. If this option is specified, the callback will be called after the execution of the scripts.
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("If true any &lt;script> tags embedded in the response text will be extracted and executed. If this option is specified, the callback will be called after the execution of the scripts.")]
        public virtual bool Scripts
        {
            get
            {
                object obj = this.ViewState["Scripts"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Scripts"] = value;
            }
        }

        /// <summary>
        /// A function to be called when the response from the server arrives.(el : Ext.Element, success : Boolean, response : XMLHttpRequest, options : Object)
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("A function to be called when the response from the server arrives.(el : Ext.Element, success : Boolean, response : XMLHttpRequest, options : Object)")]
        public virtual string Callback 
        {
            get
            {
                return (string)this.ViewState["Callback"] ?? "";
            }
            set
            {
                this.ViewState["Callback"] = value;
            }
        }

        /// <summary>
        /// If not passed as false the URL of this request becomes the default URL for this UpdateOptions object, and will be subsequently used in refresh calls.
        /// </summary>
        [ConfigOption]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("If not passed as false the URL of this request becomes the default URL for this UpdateOptions object, and will be subsequently used in refresh calls.")]
        public virtual bool DiscardUrl 
        {
            get
            {
                object obj = this.ViewState["DiscardUrl"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["DiscardUrl"] = value;
            }
        }

        /// <summary>
        /// The timeout to use when waiting for a response.
        /// </summary>
        [ConfigOption]
        [DefaultValue(30)]
        [NotifyParentProperty(true)]
        [Description("The timeout to use when waiting for a response.")]
        public virtual int Timeout
        {
            get
            {
                object obj = this.ViewState["Timeout"];
                return (obj == null) ? 30 : (int)obj;
            }
            set
            {
                this.ViewState["Timeout"] = value;
            }
        }

        /// <summary>
        /// If not passed as false the URL of this request becomes the default URL for this UpdateOptions object, and will be subsequently used in refresh calls.
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("If not passed as false the URL of this request becomes the default URL for this UpdateOptions object, and will be subsequently used in refresh calls.")]
        public virtual bool Nocache 
        {
            get
            {
                object obj = this.ViewState["Nocache"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Nocache"] = value;
            }
        }

        /// <summary>
        /// Text for loading indicator
        /// </summary>
        [ConfigOption]
        [DefaultValue("Loading...")]
        [NotifyParentProperty(true)]
        [Localizable(true)]
        [Description("Text for loading indicator")]
        public virtual string Text
        {
            get
            {
                return (string)this.ViewState["Text"] ?? "Loading...";
            }
            set
            {
                this.ViewState["Text"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return "";
        }
    }
}