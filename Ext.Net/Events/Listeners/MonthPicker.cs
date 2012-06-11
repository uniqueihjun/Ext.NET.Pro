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
    public partial class MonthPickerListeners : AbstractComponentListeners
    {
        private ComponentListener cancelClick;

        /// <summary>
        /// Fires when the cancel button is pressed.
        /// Parameters
        /// item : Ext.picker.Month
        /// </summary>
        [ListenerArgument(0, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("cancelclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the cancel button is pressed.")]
        public virtual ComponentListener CancelClick
        {
            get
            {
                return this.cancelClick ?? (this.cancelClick = new ComponentListener());
            }
        }

        private ComponentListener monthClick;

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
        [ConfigOption("monthclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month is clicked.")]
        public virtual ComponentListener MonthClick
        {
            get
            {
                return this.monthClick ?? (this.monthClick = new ComponentListener());
            }
        }

        private ComponentListener monthDblClick;

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
        [ConfigOption("monthdblclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month is double clicked.")]
        public virtual ComponentListener MonthDblClick
        {
            get
            {
                return this.monthDblClick ?? (this.monthDblClick = new ComponentListener());
            }
        }

        private ComponentListener okClick;

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
        [ConfigOption("okclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the ok button is pressed.")]
        public virtual ComponentListener OKClick
        {
            get
            {
                return this.okClick ?? (this.okClick = new ComponentListener());
            }
        }

        private ComponentListener select;

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
        [ConfigOption("select", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a month/year is selected.")]
        public virtual ComponentListener Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentListener());
            }
        }

        private ComponentListener yearClick;

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
        [ConfigOption("yearclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a year is clicked.")]
        public virtual ComponentListener YearClick
        {
            get
            {
                return this.yearClick ?? (this.yearClick = new ComponentListener());
            }
        }

        private ComponentListener yearDblClick;

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
        [ConfigOption("yeardblclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a year is double clicked.")]
        public virtual ComponentListener YearDblClick
        {
            get
            {
                return this.yearDblClick ?? (this.yearDblClick = new ComponentListener());
            }
        }
    }
}
