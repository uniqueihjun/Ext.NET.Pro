/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class UpdateOptions : BaseItem
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
                return this.State.Get<string>("Url", "");
            }
            set
            {
                this.State.Set("Url", value);
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
                return this.State.Get<HttpMethod>("Method", HttpMethod.Default);
            }
            set
            {
                this.State.Set("Method", value);
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
                return this.State.Get<string>("Params", "");
            }
            set
            {
                this.State.Set("Params", value);
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
                return this.State.Get<bool>("Scripts", false);
            }
            set
            {
                this.State.Set("Scripts", value);
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
                return this.State.Get<string>("Callback", "");
            }
            set
            {
                this.State.Set("Callback", value);
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
                return this.State.Get<bool>("DiscardUrl", true);
            }
            set
            {
                this.State.Set("DiscardUrl", value);
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
                return this.State.Get<int>("Timeout", 30);
            }
            set
            {
                this.State.Set("Timeout", value);
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
                return this.State.Get<bool>("Nocache", false);
            }
            set
            {
                this.State.Set("Nocache", value);
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
                return this.State.Get<string>("Text", "Loading...");
            }
            set
            {
                this.State.Set("Text", value);
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