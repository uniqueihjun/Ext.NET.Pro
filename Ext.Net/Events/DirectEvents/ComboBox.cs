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
	[Description("")]
    public partial class ComboBoxDirectEvents : PickerFieldDirectEvents
    {
        public ComboBoxDirectEvents() { }

        public ComboBoxDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforeQuery;

        /// <summary>
        /// Fires before all queries are processed. Return false to cancel the query or set the queryEvent's cancel property to true.
        /// Parameters
        /// queryEvent : Object
        /// An object that has these properties:
        ///     combo : Ext.form.field.ComboBox
        ///         This combo box
        ///     query : String
        ///         The query string
        ///     forceAll : Boolean
        ///         True to force "all" query
        ///     cancel : Boolean
        ///         Set to true to cancel the query
        /// </summary>
        [ListenerArgument(0, "queryEvent", typeof(object), "An object that includes combo (This combo box), query (The query), forceAll (True to force 'all' query) and cancel (Set to true to cancel the query).")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforequery", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before all queries are processed. Return false to cancel the query or set the queryEvent's cancel property to true.")]
        public virtual ComponentDirectEvent BeforeQuery
        {
            get
            {
                return this.beforeQuery ?? (this.beforeQuery = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeSelect;

        /// <summary>
        /// Fires before the selected item is added to the collection
        /// Parameters
        /// item : Ext.form.field.ComboBox
        ///     This combo box
        /// record : Ext.data.Record
        ///     The selected record
        /// index : Number
        ///     The index of the selected record
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This combo box")]
        [ListenerArgument(1, "record", typeof(object), "The data record returned from the underlying store")]
        [ListenerArgument(2, "index", typeof(int), "The index of the selected item in the dropdown list")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the selected item is added to the collection")]
        public virtual ComponentDirectEvent BeforeSelect
        {
            get
            {
                return this.beforeSelect ?? (this.beforeSelect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent beforeDeselect;

        /// <summary>
        /// Fires before the deselected item is removed from the collection
        /// Parameters
        /// item : Ext.form.field.ComboBox
        ///     This combo box
        /// record : Ext.data.Record
        ///     The deselected record
        /// index : Number
        ///     The index of the deselected record
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This combo box")]
        [ListenerArgument(1, "record", typeof(object), "The deselected record")]
        [ListenerArgument(2, "index", typeof(int), "The index of the deselected record")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforedeselect", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the deselected item is removed from the collection")]
        public virtual ComponentDirectEvent BeforeDeselect
        {
            get
            {
                return this.beforeDeselect ?? (this.beforeDeselect = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fires when at least one list item is selected.
        /// Parameters
        /// item : Ext.form.field.ComboBox
        ///     This combo box
        /// records : Array
        ///     The selected records
        /// </summary>
        [ListenerArgument(0, "item", typeof(Field), "This combo box")]
        [ListenerArgument(1, "records", typeof(object), "The data record returned from the underlying store")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when at least one list item is selected.")]
        public override ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}