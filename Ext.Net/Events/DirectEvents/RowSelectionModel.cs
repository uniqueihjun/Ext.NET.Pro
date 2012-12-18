/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class RowSelectionModelDirectEvents : AbstractSelectionModelDirectEvents
    {
        public RowSelectionModelDirectEvents() { }

        public RowSelectionModelDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeDeselect;

        /// <summary>
        /// Fired before a record is deselected. If any listener returns false, the deselection is cancelled.
        /// Parameters
        /// item : Ext.selection.RowSelectionModel
        /// record : Ext.data.Model
        ///     The deselected record
        /// index : Number
        ///     The row index deselected
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforedeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before a record is deselected. If any listener returns false, the deselection is cancelled.")]
        public virtual ComponentDirectEvent BeforeDeselect
        {
            get
            {
                return this.beforeDeselect ?? (this.beforeDeselect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent deselect;

        /// <summary>
        /// Fired after a record is deselected
        /// Parameters
        /// item : Ext.selection.RowSelectionModel
        /// record : Ext.data.Model
        ///     The deselected record
        /// index : Number
        ///     The row index deselected
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("deselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a record is deselected")]
        public virtual ComponentDirectEvent Deselect
        {
            get
            {
                if (this.deselect == null)
                {
                    ;
                }

                return this.deselect ?? (this.deselect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeSelect;

        /// <summary>
        /// Fired before a record is selected. If any listener returns false, the selection is cancelled.
        /// Parameters
        /// item : Ext.selection.RowSelectionModel
        /// record : Ext.data.Model
        ///     The selected record
        /// index : Number
        ///     The row index selected
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before a record is selected. If any listener returns false, the selection is cancelled.")]
        public virtual ComponentDirectEvent BeforeSelect
        {
            get
            {
                return this.beforeSelect ?? (this.beforeSelect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fired after a record is selected
        /// 
        /// Parameters
        /// item : Ext.selection.RowSelectionModel
        /// record : Ext.data.Model
        ///     The selected record
        /// index : Number
        ///     The row index selected
        /// </summary>
        [ListenerArgument(0, "item", typeof(RowSelectionModel), "this")]
        [ListenerArgument(1, "record")]
        [ListenerArgument(2, "index")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a record is selected")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}