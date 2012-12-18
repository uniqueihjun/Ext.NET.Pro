/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [Description("")]
    public partial class BaseLoadConfig : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Url.IsEmpty();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string Serialize()
        {
            return new ClientConfig().Serialize(this);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
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
		/// 
		/// </summary>
        [ConfigOption("url")]
        [DefaultValue("")]
		[Description("")]
        protected virtual string UrlProxy
        {
            get
            {
                return this.Owner == null ? this.Url : this.Owner.ResolveClientUrl(this.Url);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
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
		/// 
		/// </summary>
        [ConfigOption("callback", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected string CallbackProxy
        {
            get
            {
                if (this.Callback.IsNotEmpty())
                {
                    return new JFunction(TokenUtils.ParseTokens(this.Callback), "el", "success", "response", "options").ToScript();
                }

                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Scope
        {
            get
            {
                return this.State.Get<string>("Scope", "");
            }
            set
            {
                this.State.Set("Scope", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool DiscardUrl
        {
            get
            {
                return this.State.Get<bool>("DiscardUrl", false);
            }
            set
            {
                this.State.Set("DiscardUrl", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("nocache")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual bool NoCache
        {
            get
            {
                return this.State.Get<bool>("NoCache", false);
            }
            set
            {
                this.State.Set("NoCache", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string Text
        {
            get
            {
                return this.State.Get<string>("Text", "");
            }
            set
            {
                this.State.Set("Text", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
		[Description("")]
        public virtual bool Scripts
        {
            get
            {
                return this.State.Get<bool>("Scripts", true);
            }
            set
            {
                this.State.Set("Scripts", value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("scripts")]
        [DefaultValue(false)]
		[Description("")]
        protected virtual bool ScriptsProxy
        {
            get
            {
                return this.Scripts;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual int Timeout
        {   
            get
            {
                return this.State.Get<int>("Timeout", 0);
            }
            set
            {
                this.State.Set("Timeout", value);
            }
        }

        private ParameterCollection extraParams;

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.ArrayToObject)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual ParameterCollection Params
        {
            get
            {
                if (this.extraParams == null)
                {
                    this.extraParams = new ParameterCollection();
                    this.extraParams.Owner = this.Owner;
                }

                return this.extraParams;
            }
        }

        /// <summary>
        /// The HTTP method to use. Defaults to POST if params are present, or GET if not.
        /// </summary>
        [ConfigOption("method")]
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
    }
}