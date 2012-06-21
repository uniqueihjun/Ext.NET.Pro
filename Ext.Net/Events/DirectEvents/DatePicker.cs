/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class DatePickerDirectEvents : AbstractComponentDirectEvents
    {
        public DatePickerDirectEvents() { }

        public DatePickerDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fires when a date is selected.
        /// Parameters
        /// item : Ext.picker.Date
        ///     DatePicker
        /// date : Date
        ///     The selected date
        /// </summary>
        [ListenerArgument(0, "item", typeof(DatePicker), "this")]
        [ListenerArgument(1, "date", typeof(DateTime), "The selected date")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when a date is selected.")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}