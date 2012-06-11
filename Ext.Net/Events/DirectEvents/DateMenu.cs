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
    public partial class DateMenuDirectEvents : MenuDirectEvents
    {
        public DateMenuDirectEvents() { }

        public DateMenuDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent select;

        /// <summary>
        /// Fires when a date is selected
        /// Parameters
        /// item : Ext.picker.Date
        ///     DatePicker
        /// date : Date
        ///     The selected date
        /// </summary>
        [ListenerArgument(0, "item", typeof(DatePicker), "picker")]
        [ListenerArgument(1, "date", typeof(object), "Date")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Select
        {
            get
            {
                return this.select ?? (this.select = new ComponentDirectEvent(this));
            }
        }
    }
}