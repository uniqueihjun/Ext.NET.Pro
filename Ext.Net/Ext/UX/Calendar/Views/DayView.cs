/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// Unlike other calendar views, is not actually a subclass of CalendarView. 
    /// Instead it is a Container subclass that internally creates and manages 
    /// the layouts of a DayHeaderView and a DayBodyView. 
    /// As such DayView accepts any config values that are valid for DayHeaderView and DayBodyView 
    /// and passes those through to the contained views. 
    /// It also supports the interface required of any calendar view and in turn 
    /// calls methods on the contained views as necessary.
    /// </summary>
    [Meta]
    public partial class DayView : Container
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public DayView() { }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.calendar.view.Day";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("0. About")]
        [Description("")]
        public override string XType
        {
            get
            {
                return "dayview";
            }
        }

        /// <summary>
        /// The number of days to display in the view (defaults to 1). Only values from 1 to 7 are allowed.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DayView")]
        [DefaultValue(1)]
        [NotifyParentProperty(true)]
        [Description("The number of days to display in the view (defaults to 1). Only values from 1 to 7 are allowed.")]
        public virtual int DayCount
        {
            get
            {
                object obj = this.ViewState["DayCount"];
                return obj != null ? (int)obj : 1;
            }
            set
            {
                this.ViewState["DayCount"] = value;
            }
        }

        /// <summary>
        /// The text to display inside the drag proxy while dragging over the calendar to create a new event (defaults to 'Create event for {0}' where {0} is a date range supplied by the view)
        /// </summary>
        [Meta]
        [ConfigOption("ddCreateEventText")]
        [Category("6. DayView")]
        [DefaultValue("Create event for {0}")]
        [NotifyParentProperty(true)]
        [Description("The text to display inside the drag proxy while dragging over the calendar to create a new event (defaults to 'Create event for {0}' where {0} is a date range supplied by the view)")]
        public virtual string DDCreateEventText
        {
            get
            {
                return (string)this.ViewState["DDCreateEventText"] ?? "Create event for {0}";
            }
            set
            {
                this.ViewState["DDCreateEventText"] = value;
            }
        }

        /// <summary>
        /// The text to display inside the drag proxy while dragging an event to reposition it (defaults to 'Move event to {0}' where {0} is the updated event start date/time supplied by the view)
        /// </summary>
        [Meta]
        [ConfigOption("ddMoveEventText")]
        [Category("6. DayView")]
        [DefaultValue("Move event to {0}")]
        [NotifyParentProperty(true)]
        [Description("The text to display inside the drag proxy while dragging an event to reposition it (defaults to 'Move event to {0}' where {0} is the updated event start date/time supplied by the view)")]
        public virtual string DDMoveEventText
        {
            get
            {
                return (string)this.ViewState["DDMoveEventText"] ?? "Move event to {0}";
            }
            set
            {
                this.ViewState["DDMoveEventText"] = value;
            }
        }

        /// <summary>
        /// True to display the current time in today's box in the calendar, false to not display it (defautls to true)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DayView")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to display the current time in today's box in the calendar, false to not display it (defautls to true)")]
        public virtual bool ShowTime
        {
            get
            {
                object obj = this.ViewState["ShowTime"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowTime"] = value;
            }
        }

        /// <summary>
        /// True to display the todayText string in today's box in the calendar, false to not display it (defautls to true)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DayView")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to display the todayText string in today's box in the calendar, false to not display it (defautls to true)")]
        public virtual bool ShowTodayText
        {
            get
            {
                object obj = this.ViewState["ShowTodayText"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowTodayText"] = value;
            }
        }

        /// <summary>
        /// The text to display in the current day's box in the calendar when showTodayText is true (defaults to 'Today')
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("6. DayView")]
        [DefaultValue("Today")]
        [NotifyParentProperty(true)]
        [Description("The text to display in the current day's box in the calendar when showTodayText is true (defaults to 'Today')")]
        public virtual string TodayText
        {
            get
            {
                return (string)this.ViewState["TodayText"] ?? "Today";
            }
            set
            {
                this.ViewState["TodayText"] = value;
            }
        }

        /// <summary>
        /// Shifts the view by the passed number of days relative to the currently set date
        /// </summary>
        /// <param name="value">The number of days (positive or negative) by which to shift the view</param>
        public void MoveDays(int value)
        {
            this.Call("moveDays", value);
        }

        /// <summary>
        /// Updates the view to the next consecutive date(s)
        /// </summary>
        public void MoveNext()
        {
            this.Call("moveNext");
        }

        /// <summary>
        /// Updates the view to the previous consecutive date(s)
        /// </summary>
        public void MovePrev()
        {
            this.Call("movePrev");
        }

        /// <summary>
        /// Updates the view to contain the passed date
        /// </summary>
        /// <param name="dt">The date to display</param>
        public void MoveTo(DateTime dt)
        {
            this.Call("moveTo", dt);
        }

        /// <summary>
        /// Updates the view to show today
        /// </summary>
        public void MoveToday()
        {
            this.Call("moveToday");
        }

        /// <summary>
        /// Sets the start date used to calculate the view boundaries to display. The displayed view will be the earliest and latest dates that match the view requirements and contain the date passed to this function.
        /// </summary>
        /// <param name="dt">The date used to calculate the new view boundaries</param>
        public void SetStartDate(DateTime dt)
        {
            this.Call("setStartDate", dt);
        }
    }
}