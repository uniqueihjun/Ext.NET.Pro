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
    public partial class MonthPickerDirectEvents : AbstractComponentDirectEvents
    {
        public MonthPickerDirectEvents() { }

        public MonthPickerDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent cancelClick;

        /// <summary>
        /// Fires when the cancel button is pressed.
        /// Parameters
        /// item : Ext.picker.Month
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("cancelclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the cancel button is pressed.")]
        public virtual ComponentDirectEvent CancelClick
        {
            get
            {
                return this.cancelClick ?? (this.cancelClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent monthClick;

        /// <summary>
        /// Fires when a month is clicked.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("monthclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month is clicked.")]
        public virtual ComponentDirectEvent MonthClick
        {
            get
            {
                return this.monthClick ?? (this.monthClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent monthDblClick;

        /// <summary>
        /// Fires when a month is double clicked.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("monthdblclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month is double clicked.")]
        public virtual ComponentDirectEvent MonthDblClick
        {
            get
            {
                return this.monthDblClick ?? (this.monthDblClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent okClick;

        /// <summary>
        /// Fires when the ok button is pressed.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("okclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the ok button is pressed.")]
        public virtual ComponentDirectEvent OKClick
        {
            get
            {
                return this.okClick ?? (this.okClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fires when a month/year is selected.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month/year is selected.")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent yearClick;

        /// <summary>
        /// Fires when a year is clicked.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("yearclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a year is clicked.")]
        public virtual ComponentDirectEvent YearClick
        {
            get
            {
                return this.yearClick ?? (this.yearClick = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent yearDblClick;

        /// <summary>
        /// Fires when a year is double clicked.
        /// Parameters
        /// item : Ext.picker.Month
        /// value : Array
        ///     The current value, an array with the month as the first index and the year as the second.
        /// </summary>
        [ListenerArgument(0, "item")]
        [ListenerArgument(1, "value")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("yeardblclick", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a year is double clicked.")]
        public virtual ComponentDirectEvent YearDblClick
        {
            get
            {
                return this.yearDblClick ?? (this.yearDblClick = new ComponentDirectEvent(this));
            }
        }
    }
}
