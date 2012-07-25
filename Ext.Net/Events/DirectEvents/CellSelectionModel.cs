/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class CellSelectionModelDirectEvents : AbstractSelectionModelDirectEvents
    {
        public CellSelectionModelDirectEvents() { }

        public CellSelectionModelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent deselect;

        /// <summary>
        /// Fired after a cell is deselected
        /// Parameters
        /// item : Ext.selection.CellModel
        /// record : Ext.data.Model
        ///     The record of the deselected cell
        /// row : Number
        ///     The row index deselected
        /// column : Number
        ///     The column index deselected
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "row")]
        [ListenerArgument(3, "column")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a cell is deselected")]
        public virtual ComponentDirectEvent Deselect
        {
            get
            {
                return this.deselect ?? (this.deselect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fired after a cell is selected
        /// Parameters
        /// item : Ext.selection.CellModel
        /// record : Ext.data.Model
        ///     The record of the selected cell
        /// row : Number
        ///     The row index selected
        /// column : Number
        ///     The column index selected
        /// </summary>
        [ListenerArgument(0, "item", typeof(CellSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "row")]
        [ListenerArgument(3, "column")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a cell is selected.")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}