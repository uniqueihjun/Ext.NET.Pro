/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// The TreeStore is a store implementation that is backed by by an Ext.data.Tree. It provides convenience methods for loading nodes, as well as the ability to use the hierarchical tree structure combined with a store. This class is generally used in conjunction with Ext.tree.Panel. This class also relays many events from the Tree for convenience.
    /// 
    /// Using Models
    /// If no Model is specified, an implicit model will be created that implements Ext.data.NodeInterface. The standard Tree fields will also be copied onto the Model for maintaining their state.
    /// 
    /// Reading Nested Data
    /// For the tree to read nested data, the Ext.data.reader.Reader must be configured with a root property, so the reader can find nested data for each node. If a root is not specified, it will default to 'children'.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:TreeStore runat=\"server\"></{0}:TreeStore>")]
    [Designer(typeof(EmptyDesigner))]
    [ToolboxBitmap(typeof(Store), "Build.ToolboxIcons.Store.bmp")]
    [Description("The TreeStore is a store implementation that is backed by by an Ext.data.Tree. It provides convenience methods for loading nodes, as well as the ability to use the hierarchical tree structure combined with a store. This class is generally used in conjunction with Ext.tree.Panel. This class also relays many events from the Tree for convenience.")]
    public partial class TreeStore : TreeStoreBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TreeStore() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.data.TreeStore";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoreType
        {
            get
            {
                return "tree";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected internal override bool IsIdRequired
        {
            get
            {
                return !this.IsDynamic;
            }
        }

        private TreeStoreListeners listeners;

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
        public TreeStoreListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new TreeStoreListeners();
                }

                return this.listeners;
            }
        }

        private TreeStoreDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Description("Server-side Ajax Event Handlers")]
        public TreeStoreDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new TreeStoreDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
