/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class GridPanelDirectEvents : TablePanelDirectEvents
    {
        public GridPanelDirectEvents() { }

        public GridPanelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent groupClick;

        /// <summary>
        /// Fires when group header is clicked. Only applies for grids with a Grouping feature.
        /// Parameters
        /// view : Ext.view.Table
        /// node : HTMLElement
        /// group : String
        /// The name of the group
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "view", typeof(TableView))]
        [ListenerArgument(1, "node", typeof(string))]
        [ListenerArgument(2, "group")]
        [ListenerArgument(3, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when group header is clicked. Only applies for grids with a Grouping feature.")]
        public virtual ComponentDirectEvent GroupClick
        {
            get
            {
                return this.groupClick ?? (this.groupClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupContextMenu;

        /// <summary>
        /// Fires when group header is right clicked. Only applies for grids with a Grouping feature.
        /// Parameters
        /// view : Ext.view.Table
        /// node : HTMLElement
        /// group : String
        /// The name of the group
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "view", typeof(TableView))]
        [ListenerArgument(1, "node", typeof(string))]
        [ListenerArgument(2, "group")]
        [ListenerArgument(3, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupcontextmenu", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when group header is right clicked. Only applies for grids with a Grouping feature.")]
        public virtual ComponentDirectEvent GroupContextMenu
        {
            get
            {
                return this.groupContextMenu ?? (this.groupContextMenu = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupDblClick;

        /// <summary>
        /// Fires when group header is double clicked. Only applies for grids with a Grouping feature.
        /// Parameters
        /// view : Ext.view.Table
        /// node : HTMLElement
        /// group : String
        /// The name of the group
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "view", typeof(TableView))]
        [ListenerArgument(1, "node", typeof(string))]
        [ListenerArgument(2, "group")]
        [ListenerArgument(3, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupdblclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when group header is double clicked. Only applies for grids with a Grouping feature.")]
        public virtual ComponentDirectEvent GroupDblClick
        {
            get
            {
                return this.groupDblClick ?? (this.groupDblClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupCollapse;

        /// <summary>
        /// Fires when group header is collapsed. Only applies for grids with a Grouping feature.
        /// Parameters
        /// view : Ext.view.Table
        /// node : HTMLElement
        /// group : String
        /// The name of the group
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "view", typeof(TableView))]
        [ListenerArgument(1, "node", typeof(string))]
        [ListenerArgument(2, "group")]
        [ListenerArgument(3, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupcollapse", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when group header is collapsed. Only applies for grids with a Grouping feature.")]
        public virtual ComponentDirectEvent GroupCollapse
        {
            get
            {
                return this.groupCollapse ?? (this.groupCollapse = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupExpand;

        /// <summary>
        /// Fires when group header is double expanded. Only applies for grids with a Grouping feature.
        /// Parameters
        /// view : Ext.view.Table
        /// node : HTMLElement
        /// group : String
        /// The name of the group
        /// e : Ext.EventObject
        /// </summary>
        [ListenerArgument(0, "view", typeof(TableView))]
        [ListenerArgument(1, "node", typeof(string))]
        [ListenerArgument(2, "group")]
        [ListenerArgument(3, "e")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupexpand", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when group header is double expanded. Only applies for grids with a Grouping feature.")]
        public virtual ComponentDirectEvent GroupExpand
        {
            get
            {
                return this.groupExpand ?? (this.groupExpand = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent reconfigure;

        /// <summary>
        /// Fires after a reconfigure
        /// Parameters
        /// item : Ext.grid.Panel
        /// store : Ext.data.Store
        ///     The store that was passed to the reconfigure method
        /// columns : Object[]
        ///     The column configs that were passed to the reconfigure method
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "store")]
        [ListenerArgument(2, "columns")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("reconfigure", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a reconfigure")]
        public override ComponentDirectEvent Reconfigure
        {
            get
            {
                return this.reconfigure ?? (this.reconfigure = new ComponentDirectEvent(this));
            }
        }
    }
}