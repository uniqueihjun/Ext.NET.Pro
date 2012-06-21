/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    [Meta]
    [ToolboxItem(false)]
    public partial class TreeView : TableView
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public TreeView() { }

        /// <summary>
        /// 
        /// </summary>
        public override string XType
        {
            get
            {
                return "treeview";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.tree.View";
            }
        }

        /// <summary>
        /// True to enable animated expand/collapse (defaults to the value of Ext.enableFx)
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("True to enable animated expand/collapse (defaults to the value of Ext.enableFx)")]
        public virtual bool Animate
        {
            get
            {
                return this.State.Get<bool>("Animate", true);
            }
            set
            {
                this.State.Set("Animate", value);
            }
        }

        /// <summary>
        /// False to hide the root node (defaults to true)
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue(true)]
        [Description("False to hide the root node (defaults to true)")]
        public virtual bool RootVisible
        {
            get
            {
                return this.State.Get<bool>("RootVisible", true);
            }
            set
            {
                this.State.Set("RootVisible", value);
            }
        }

        private TableViewListeners listeners;

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
        public TableViewListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new TableViewListeners();
                }

                return this.listeners;
            }
        }

        private TableViewDirectEvents directEvents;

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
        public TableViewDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new TableViewDirectEvents(this);
                }

                return this.directEvents;
            }
        }
    }
}
