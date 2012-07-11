/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class CellSelectionModelDirectEvents : ComponentBaseDirectEvents
    {
        private ComponentDirectEvent beforeCellSelect;

        /// <summary>
        /// Fires before a cell is selected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "colIndex")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecellselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a cell is selected.")]
        public virtual ComponentDirectEvent BeforeCellSelect
        {
            get
            {
                if (this.beforeCellSelect == null)
                {
                    this.beforeCellSelect = new ComponentDirectEvent();
                }

                return this.beforeCellSelect;
            }
        }

        private ComponentDirectEvent cellSelect;

        /// <summary>
        /// Fires when a cell is selected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "colIndex")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("cellselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a cell is selected.")]
        public virtual ComponentDirectEvent CellSelect
        {
            get
            {
                if (this.cellSelect == null)
                {
                    this.cellSelect = new ComponentDirectEvent();
                }

                return this.cellSelect;
            }
        }

        private ComponentDirectEvent selectionChange;

        /// <summary>
        /// Fires when the active selection changes.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "selection")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the active selection changes.")]
        public virtual ComponentDirectEvent SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentDirectEvent();
                }

                return this.selectionChange;
            }
        }
    }
}