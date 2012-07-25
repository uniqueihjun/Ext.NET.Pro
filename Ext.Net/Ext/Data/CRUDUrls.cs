/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Specific urls to call on CRUD action methods "read", "create", "update" and "destroy"
    /// </summary>
    [Description("")]
    [Meta]
    public partial class CRUDUrls : BaseItem
    {
        /// <summary>
        /// 
        /// </summary>
        public CRUDUrls()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Sync
        {
            get
            {
                return this.State.Get<string>("Sync", "");
            }
            set
            {
                this.State.Set("Sync", value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("sync", JsonMode.Raw)]
        [DefaultValue("")]
        [Description("")]
        protected virtual string SyncProxy
        {
            get
            {
                string url = this.ResolveUrl(this.Sync);

                if (url.IsEmpty())
                {
                    return "";
                }

                return JSON.Serialize(url);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public string Create
        {
            get
            {
                return this.State.Get<string>("Create", "");
            }
            set
            {
                this.State.Set("Create", value);
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
                string url = this.ResolveUrl(this.Create);

                if (url.IsEmpty())
                {
                    return "";
                }

                return JSON.Serialize(url);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Meta]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string Read
        {
            get
            {
                return this.State.Get<string>("Read", "");
            }
            set
            {
                this.State.Set("Read", value);
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
                string url = this.ResolveUrl(this.Read);

                if (url.IsEmpty())
                {
                    return "";
                }

                return JSON.Serialize(url);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Meta]        
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string Update
        {
            get
            {
                return this.State.Get<string>("Update", "");
            }
            set
            {
                this.State.Set("Update", value);
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
                string url = this.ResolveUrl(this.Update);

                if (url.IsEmpty())
                {
                    return "";
                }

                return JSON.Serialize(url);
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Meta]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
		[Description("")]
        public string Destroy
        {
            get
            {
                return this.State.Get<string>("Destroy", "");
            }
            set
            {
                this.State.Set("Destroy", value);
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
                string url = this.ResolveUrl(this.Destroy);

                if (url.IsEmpty())
                {
                    return "";
                }

                return JSON.Serialize(url);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public bool SkipUrlResolving
        {
            get;
            internal set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        protected virtual string ResolveUrl(string url)
        {
            if (this.SkipUrlResolving)
            {
                return url;
            }

            if (this.Owner is BaseControl)
            {
                return ((BaseControl)this.Owner).ResolveUrlLink(url);
            }

            return this.Owner == null ? url : this.Owner.ResolveUrl(url);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return this.Sync.IsEmpty() &&
                       this.Create.IsEmpty() &&
                       this.Read.IsEmpty() &&
                       this.Update.IsEmpty() &&
                       this.Destroy.IsEmpty();
            }
        }
    }
}