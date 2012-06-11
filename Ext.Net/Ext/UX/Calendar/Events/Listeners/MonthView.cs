/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    public partial class MonthViewListeners : AbstractCalendarViewListeners
    {
        private ComponentListener dayClick;

        /// <summary>
        /// Fires after the user clicks within the view container and not on an event element. This is a cancelable event, so returning false from a handler will cancel the click without displaying the event editor view. This could be useful for validating that a user can only create events on certain days.
        /// Listeners will be called with the following arguments:
        /// this : Extensible.calendar.view.Month
        /// dt : Date
        /// The date/time that was clicked on
        /// allday : Boolean
        /// True if the day clicked on represents an all-day box, else false. Clicks within the MonthView always return true for this param.
        /// el : Ext.Element
        /// The Element that was clicked on
        /// </summary>
        [ListenerArgument(0, "item", typeof(MonthView), "Ext.calendar.MonthView")]
        [ListenerArgument(1, "dt", typeof(DateTime), "The date/time that was clicked on")]
        [ListenerArgument(2, "allDay", typeof(bool), "True if the day clicked on represents an all-day box, else false. Clicks within the MonthView always return true for this param.")]
        [ListenerArgument(3, "el", typeof(Element), "The Element that was clicked on")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dayclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the user clicks within the view container and not on an event element. This is a cancelable event, so returning false from a handler will cancel the click without displaying the event editor view. This could be useful for validating that a user can only create events on certain days.")]
        public virtual ComponentListener DayClick
        {
            get
            {
                if (this.dayClick == null)
                {
                    this.dayClick = new ComponentListener();
                }

                return this.dayClick;
            }
        }

        private ComponentListener weekClick;

        /// <summary>
        /// Fires after the user clicks within a week link (when #showWeekLinks is true)
        /// Listeners will be called with the following arguments:
        /// this : Extensible.calendar.view.Month
        /// dt : Date
        /// The start date of the week that was clicked on
        /// </summary>
        [ListenerArgument(0, "item", typeof(MonthView), "Ext.calendar.MonthView")]
        [ListenerArgument(1, "dt", typeof(DateTime), "The start date of the week that was clicked on")]        
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("weekclick", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the user clicks within a week link (when #showWeekLinks is true)")]
        public virtual ComponentListener WeekClick
        {
            get
            {
                if (this.weekClick == null)
                {
                    this.weekClick = new ComponentListener();
                }

                return this.weekClick;
            }
        }
    }
}