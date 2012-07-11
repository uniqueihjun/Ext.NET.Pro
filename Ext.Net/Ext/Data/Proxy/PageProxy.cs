/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    [Meta]
    public partial class PageProxy : ServerProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public PageProxy()
        {
        }
        
        /// <summary>
        /// Alias
        /// </summary>
        [ConfigOption]
        [DefaultValue(null)]
        protected override string Type
        {
            get
            {
                return "page";
            }
        }

        private CRUDUrls api;

        /// <summary>
        /// Specific direct methods to call on CRUD action methods "read", "create", "update" and "destroy".        
        /// </summary>
        [ConfigOption("api", JsonMode.Object)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specific direct methods to call on CRUD action methods \"read\", \"create\", \"update\" and \"destroy\".")]
        public override CRUDUrls API
        {
            get
            {
                return this.api ?? (this.api = new CRUDUrls { Owner = this.Owner, SkipUrlResolving = true });
            }
        }
        
        private int total;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [DefaultValue(0)]
        [Description("")]
        public int Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual string DirectFn
        {
            get
            {
                return this.State.Get<string>("DirectFn", "");
            }
            set
            {
                this.State.Set("DirectFn", value);
            }
        }

        private BaseDirectEvent requestConfig;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [ConfigOption(JsonMode.Object)]
        [Description("")]
        public BaseDirectEvent RequestConfig
        {
            get
            {
                if (this.requestConfig == null)
                {
                    this.requestConfig = new BaseDirectEvent();
                }

                return this.requestConfig;
            }
        }
    }
}
