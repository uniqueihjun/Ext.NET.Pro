/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Specific urls to call on REST action methods "read", "create", "update" and "destroy"
    /// </summary>
    [Description("")]
    public partial class RestUrls : StateManagedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public string CreateUrl
        {
            get
            {
                return (string)this.ViewState["CreateUrl"] ?? "";
            }
            set
            {
                this.ViewState["CreateUrl"] = value;
            }
        }

        /// <summary>       
        /// 
        /// </summary>
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual HttpMethod CreateMethod
        {
            get
            {
                object obj = this.ViewState["CreateMethod"];
                return obj == null ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["CreateMethod"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("create", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string CreateProxy
        {
            get
            {
                string url = this.ResolveUrl(this.CreateUrl);

                if (url.IsEmpty())
                {
                    return "";
                }

                return this.CreateMethod == HttpMethod.Default ? JSON.Serialize(url) : this.APIActionTemplate.FormatWith(url, this.CreateMethod.ToString());
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string ReadUrl
        {
            get
            {
                return (string)this.ViewState["ReadUrl"] ?? "";
            }
            set
            {
                this.ViewState["ReadUrl"] = value;
            }
        }

        /// <summary>     
        /// 
        /// </summary>
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual HttpMethod ReadMethod
        {
            get
            {
                object obj = this.ViewState["ReadMethod"];
                return obj == null ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["ReadMethod"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("read", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string ReadProxy
        {
            get
            {
                string url = this.ResolveUrl(this.ReadUrl);

                if (url.IsEmpty())
                {
                    return "";
                }

                return this.ReadMethod == HttpMethod.Default ? JSON.Serialize(url) : this.APIActionTemplate.FormatWith(url, this.ReadMethod.ToString());
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string UpdateUrl
        {
            get
            {
                return (string)this.ViewState["UpdateUrl"] ?? "";
            }
            set
            {
                this.ViewState["UpdateUrl"] = value;
            }
        }

        /// <summary>     
        /// 
        /// </summary>
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual HttpMethod UpdateMethod
        {
            get
            {
                object obj = this.ViewState["UpdateMethod"];
                return obj == null ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["UpdateMethod"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("update", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string UpdateProxy
        {
            get
            {
                string url = this.ResolveUrl(this.UpdateUrl);

                if (url.IsEmpty())
                {
                    return "";
                }

                return this.UpdateMethod == HttpMethod.Default ? JSON.Serialize(url) : this.APIActionTemplate.FormatWith(url, this.UpdateMethod.ToString());
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string DestroyUrl
        {
            get
            {
                return (string)this.ViewState["DestroyUrl"] ?? "";
            }
            set
            {
                this.ViewState["DestroyUrl"] = value;
            }
        }

        /// <summary>     
        /// 
        /// </summary>
        [DefaultValue(HttpMethod.Default)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual HttpMethod DestroyMethod
        {
            get
            {
                object obj = this.ViewState["DestroyMethod"];
                return obj == null ? HttpMethod.Default : (HttpMethod)obj;
            }
            set
            {
                this.ViewState["DestroyMethod"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("destroy", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string DestroyProxy
        {
            get
            {
                string url = this.ResolveUrl(this.DestroyUrl);

                if (url.IsEmpty())
                {
                    return "";
                }

                return this.DestroyMethod == HttpMethod.Default ? JSON.Serialize(url) : this.APIActionTemplate.FormatWith(url, this.DestroyMethod.ToString());
            }
        }

        protected virtual string APIActionTemplate
        {
            get
            {
                return "{{url:\"{0}\",method:\"{1}\"}}";
            }
        }

        private string ResolveUrl(string url)
        {
            return this.Owner == null ? url : this.Owner.ResolveClientUrl(url);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.CreateUrl.IsEmpty() &&
                       this.ReadUrl.IsEmpty() &&
                       this.UpdateUrl.IsEmpty() &&
                       this.DestroyUrl.IsEmpty();
            }
        }
    }
}