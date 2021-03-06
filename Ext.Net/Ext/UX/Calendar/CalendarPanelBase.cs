/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;
using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public abstract partial class CalendarPanelBase : AbstractPanel
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;

                baseList.Capacity += 2;

                baseList.Add(new ClientStyleItem(typeof(CalendarPanel), "Ext.Net.Build.Ext.Net.ux.resources.calendar-embedded.css", "/ux/resources/calendar.css"));
                baseList.Add(new ClientScriptItem(typeof(CalendarPanel), "Ext.Net.Build.Ext.Net.ux.calendar.calendar-all.js", "Ext.Net.Build.Ext.Net.ux.calendar.calendar-all-debug.js", "/ux/calendar/calendar-all.js", "/ux/calendar/calendar-all-debug.js"));

                return baseList;
            }
        }

        /// <summary>
        /// Alternate text to use for the 'Day' nav bar button.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue("Day")]
        [NotifyParentProperty(true)]
        [Description("Alternate text to use for the 'Day' nav bar button.")]
        public virtual string DayText
        {
            get
            {
                return (string)this.ViewState["DayText"] ?? "Day";
            }
            set
            {
                this.ViewState["DayText"] = value;
            }
        }

        /// <summary>
        /// Alternate text to use for the 'Month' nav bar button.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue("Month")]
        [NotifyParentProperty(true)]
        [Description("Alternate text to use for the 'Month' nav bar button.")]
        public virtual string MonthText
        {
            get
            {
                return (string)this.ViewState["MonthText"] ?? "Month";
            }
            set
            {
                this.ViewState["MonthText"] = value;
            }
        }

        /// <summary>
        /// True to include the day view (and toolbar button), false to hide them (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to include the day view (and toolbar button), false to hide them (defaults to true).")]
        public virtual bool ShowDayView 
        {
            get
            {
                object obj = this.ViewState["ShowDayView"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowDayView"] = value;
            }
        }

        /// <summary>
        /// True to include the month view (and toolbar button), false to hide them (defaults to true). If the day and week views are both hidden, the month view will show by default even if this config is false.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to include the month view (and toolbar button), false to hide them (defaults to true). If the day and week views are both hidden, the month view will show by default even if this config is false.")]
        public virtual bool ShowMonthView
        {
            get
            {
                object obj = this.ViewState["ShowMonthView"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowMonthView"] = value;
            }
        }

        /// <summary>
        /// True to display the calendar navigation toolbar, false to hide it (defaults to true). Note that if you hide the default navigation toolbar you'll have to provide an alternate means of navigating the calendar.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to display the calendar navigation toolbar, false to hide it (defaults to true). Note that if you hide the default navigation toolbar you'll have to provide an alternate means of navigating the calendar.")]
        public virtual bool ShowNavBar
        {
            get
            {
                object obj = this.ViewState["ShowNavBar"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowNavBar"] = value;
            }
        }

        /// <summary>
        /// True to display the current time next to the date in the calendar's current day box, false to not show it (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to display the current time next to the date in the calendar's current day box, false to not show it (defaults to true).")]
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
        /// True to show the value of todayText instead of today's date in the calendar's current day box, false to display the day number(defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to show the value of todayText instead of today's date in the calendar's current day box, false to display the day number(defaults to true).")]
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
        /// True to include the week view (and toolbar button), false to hide them (defaults to true).
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("True to include the week view (and toolbar button), false to hide them (defaults to true).")]
        public virtual bool ShowWeekView
        {
            get
            {
                object obj = this.ViewState["ShowWeekView"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["ShowWeekView"] = value;
            }
        }

        /// <summary>
        /// Alternate text to use for the 'Today' nav bar button.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue("Today")]
        [NotifyParentProperty(true)]
        [Description("Alternate text to use for the 'Today' nav bar button.")]
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
        /// Alternate text to use for the 'Week' nav bar button.
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("7. CalendarPanel")]
        [DefaultValue("Week")]
        [NotifyParentProperty(true)]
        [Description("Alternate text to use for the 'Week' nav bar button.")]
        public virtual string WeekText
        {
            get
            {
                return (string)this.ViewState["WeekText"] ?? "Week";
            }
            set
            {
                this.ViewState["WeekText"] = value;
            }
        }

        /// <summary>
        /// The calendar store ID to use.
        /// </summary>
        [Meta]
        [ConfigOption("calendarStore", JsonMode.ToClientID)]
        [Category("7. CalendarPanel")]
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("The calendar store ID to use.")]
        public virtual string CalendarStoreID
        {
            get
            {
                return (string)this.ViewState["CalendarStoreID"] ?? "";
            }
            set
            {
                this.ViewState["CalendarStoreID"] = value;
            }
        }
        
        private CalendarStore calendarStore;

        [Meta]
        [Category("7. CalendarPanel")]
        [ConfigOption("calendarStore", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        [DefaultValue(null)]
        public virtual CalendarStore CalendarStore
        {
            get
            {
                return this.calendarStore;
            }
            set
            {
                this.ClearWidget(this.calendarStore);
                this.calendarStore = value;
                this.AfterWidgetAdd(this.calendarStore);
            }
        }

        /// <summary>
        /// The event store ID to use.
        /// </summary>
        [Meta]
        [ConfigOption("eventStore", JsonMode.ToClientID)]
        [Category("7. CalendarPanel")]
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("The event store ID to use.")]
        public virtual string EventStoreID
        {
            get
            {
                return (string)this.ViewState["EventStoreID"] ?? "";
            }
            set
            {
                this.ViewState["EventStoreID"] = value;
            }
        }

        private EventStore eventStore;
        
        [Meta]
        [Category("7. CalendarPanel")]
        [ConfigOption("eventStore", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        [DefaultValue(null)]
        public virtual EventStore EventStore
        {
            get
            {
                return this.eventStore;
            }
            set
            {
                this.ClearWidget(this.eventStore);
                this.eventStore = value;
                this.AfterWidgetAdd(this.eventStore);
            }
        }

        private DayView dayView;

        /// <summary>
        /// A config object that will be applied only to the DayView managed by this CalendarPanel.
        /// </summary>
        [Meta]
        [ConfigOption("dayViewCfg", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DefaultValue(null)]
        [Description("")]
        public virtual DayView DayView
        {
            get
            {
                return this.dayView;
            }
            set
            {
                this.ClearWidget(this.dayView);
                this.dayView = value;
                this.AfterWidgetAdd(this.dayView);
            }
        }

        private WeekView weekView;

        /// <summary>
        /// A config object that will be applied only to the WeekView managed by this CalendarPanel.
        /// </summary>
        [Meta]
        [ConfigOption("weekViewCfg", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DefaultValue(null)]
        [Description("")]
        public virtual WeekView WeekView
        {
            get
            {
                return this.weekView;
            }
            set
            {
                this.ClearWidget(this.weekView);
                this.weekView = value;
                this.AfterWidgetAdd(this.weekView);
            }
        }

        private MonthView monthView;

        /// <summary>
        /// A config object that will be applied only to the MonthView managed by this CalendarPanel.
        /// </summary>
        [Meta]
        [ConfigOption("monthViewCfg", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DefaultValue(null)]
        [Description("")]
        public virtual MonthView MonthView
        {
            get
            {                
                return this.monthView;
            }
            set
            {
                this.ClearWidget(this.monthView);
                this.monthView = value;
                this.AfterWidgetAdd(this.monthView);
            }
        }

        private EventDetails eventDetails;

        /// <summary>
        /// A config object that will be applied only to the EventEditForm managed by this CalendarPanel.
        /// </summary>
        [Meta]
        [ConfigOption("editViewCfg", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DefaultValue(null)]
        [Description("")]
        public virtual EventDetails EventDetails
        {
            get
            {
                return this.eventDetails;
            }
            set
            {
                this.ClearWidget(this.eventDetails);
                this.eventDetails = value;
                this.eventDetails.CalendarPanel = this;
                this.AfterWidgetAdd(this.eventDetails);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        protected virtual void ClearWidget(Observable item)
        {
            if (item != null && this.Controls.Contains(item))
            {
                this.LazyItems.Remove(item);
                this.Controls.Remove(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        protected virtual void AfterWidgetAdd(Observable item)
        {
            this.LazyItems.Add(item);            
            this.Controls.Add(item);            
        }

        /* Methods */

        /// <summary>
        /// Hides the built-in event edit form and returns to the previous calendar view. If the edit form is not currently visible this method has no effect.
        /// </summary>
        public void HideEditForm()
        {
            this.Call("hideEditForm");
        }

        /// <summary>
        /// Sets the start date for the currently-active calendar view.
        /// </summary>
        /// <param name="dt">start date</param>
        public void SetStartDate(DateTime dt)
        {
            this.Call("setStartDate", dt);
        }

        /// <summary>
        /// Shows the built-in event edit form for the passed in event record. This method automatically hides the calendar views and navigation toolbar. To return to the calendar, call hideEditForm.
        /// </summary>
        /// <param name="id">The event record id to edit</param>
        public void ShowEditForm(object id)
        {
            this.Call("showEditForm", new JRawValue("{1}.store.getById({0})".FormatWith(JSON.Serialize(id), this.ClientID)));
        }

        /// <summary>
        /// Shows the built-in event edit form for the passed in event record. This method automatically hides the calendar views and navigation toolbar. To return to the calendar, call hideEditForm.
        /// </summary>
        /// <param name="id">The event record index to edit</param>
        public void ShowEditForm(int index)
        {
            this.Call("showEditForm", new JRawValue("{1}.store.getAt({0})".FormatWith(index, this.ClientID)));
        }

        /// <summary>
        /// Shows the built-in event edit form for the passed in event record. This method automatically hides the calendar views and navigation toolbar. To return to the calendar, call hideEditForm.
        /// </summary>
        /// <param name="record">The event record to edit</param>
        public void ShowEditForm(ModelProxy record)
        {
            this.Call("showEditForm", JRawValue.From(record.ModelInstance));
        }
    }
}