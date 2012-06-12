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
	/// 
	/// </summary>
	[Description("")]
    public partial class CellSelectionModelListeners : ComponentBaseListeners
    {
        private ComponentListener beforeCellSelect;

        /// <summary>
        /// Fires before a cell is selected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel),"this")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "colIndex")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforecellselect", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a cell is selected.")]
        public virtual ComponentListener BeforeCellSelect
        {
            get
            {
                if (this.beforeCellSelect == null)
                {
                    this.beforeCellSelect = new ComponentListener();
                }

                return this.beforeCellSelect;
            }
        }

        private ComponentListener cellSelect;

        /// <summary>
        /// Fires when a cell is selected.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "rowIndex")]
        [ListenerArgument(2, "colIndex")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("cellselect", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a cell is selected.")]
        public virtual ComponentListener CellSelect
        {
            get
            {
                if (this.cellSelect == null)
                {
                    this.cellSelect = new ComponentListener();
                }

                return this.cellSelect;
            }
        }

        private ComponentListener selectionChange;

        /// <summary>
        /// Fires when the active selection changes.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "selection")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selectionchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the active selection changes.")]
        public virtual ComponentListener SelectionChange
        {
            get
            {
                if (this.selectionChange == null)
                {
                    this.selectionChange = new ComponentListener();
                }

                return this.selectionChange;
            }
        }
    }
}