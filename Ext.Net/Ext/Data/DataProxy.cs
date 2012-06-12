/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This class is an abstract base class for implementations which provide retrieval of unformatted data objects.
    /// </summary>
    [Meta]
    [Description("")]
    public abstract partial class DataProxy : StateManagedItem
    {
        private DataProxyListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Client-side JavaScript Event Handlers")]
        public DataProxyListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new DataProxyListeners();
                }

                return this.listeners;
            }
        }

        private StoreBase store;

        internal StoreBase Store
        {
            get { return store; }
            set { store = value; }
        }

        private RestUrls api;

        /// <summary>
        /// Specific urls to call on REST action methods "read", "create", "update" and "destroy".
        /// </summary>
        [ConfigOption("api", JsonMode.Object)]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Specific urls to call on REST action methods \"read\", \"create\", \"update\" and \"destroy\".")]
        public RestUrls RestAPI
        {
            get
            {
                if (this.api == null)
                {
                    this.api = new RestUrls();
                    this.Owner = this.Store;
                }

                return this.api;
            }
        }

    }
}
