/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
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
    public partial class BaseLoadConfig : StateManagedItem
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
                return (string)this.ViewState["Url"] ?? "";
            }
            set
            {
                this.ViewState["Url"] = value;
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
                return (string)this.ViewState["Callback"] ?? "";
            }
            set
            {
                this.ViewState["Callback"] = value;
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
                return (string)this.ViewState["Scope"] ?? "";
            }
            set
            {
                this.ViewState["Scope"] = value;
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
                object obj = this.ViewState["DiscardUrl"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["DiscardUrl"] = value;
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
                object obj = this.ViewState["NoCache"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["NoCache"] = value;
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
                return (string)this.ViewState["Text"] ?? "";
            }
            set
            {
                this.ViewState["Text"] = value;
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
                object obj = this.ViewState["Scripts"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["Scripts"] = value;
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
                object obj = this.ViewState["Timeout"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["Timeout"] = value;
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
                object obj = this.ViewState["Method"];
                return (obj == null) ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["Method"] = value;
            }
        }
    }
}