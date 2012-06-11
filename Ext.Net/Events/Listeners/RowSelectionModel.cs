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
    public partial class RowSelectionModelListeners : AbstractSelectionModelListeners
    {
        private ComponentListener beforeDeselect;

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
        [ConfigOption("beforedeselect", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before a record is deselected. If any listener returns false, the deselection is cancelled.")]
        public virtual ComponentListener BeforeDeselect
        {
            get
            {
                return this.beforeDeselect ?? (this.beforeDeselect = new ComponentListener());
            }
        }

        private ComponentListener deselect;

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
        [ConfigOption("deselect", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a record is deselected")]
        public virtual ComponentListener Deselect
        {
            get
            {
                if (this.deselect == null)
                {
                    ;
                }

                return this.deselect ?? (this.deselect = new ComponentListener());
            }
        }

        private ComponentListener beforeSelect;

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
        [ConfigOption("beforeselect", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired before a record is selected. If any listener returns false, the selection is cancelled.")]
        public virtual ComponentListener BeforeSelect
        {
            get
            {
                return this.beforeSelect ?? (this.beforeSelect = new ComponentListener());
            }
        }

        private ComponentListener select;

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
        [ConfigOption("select", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired after a record is selected")]
        public virtual ComponentListener Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentListener());
            }
        }
    }
}