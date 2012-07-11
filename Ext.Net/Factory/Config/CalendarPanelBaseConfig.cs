/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class CalendarPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractPanel.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string dayText = "Day";

			/// <summary>
			/// Alternate text to use for the 'Day' nav bar button.
			/// </summary>
			[DefaultValue("Day")]
			public virtual string DayText 
			{ 
				get
				{
					return this.dayText;
				}
				set
				{
					this.dayText = value;
				}
			}

			private string monthText = "Month";

			/// <summary>
			/// Alternate text to use for the 'Month' nav bar button.
			/// </summary>
			[DefaultValue("Month")]
			public virtual string MonthText 
			{ 
				get
				{
					return this.monthText;
				}
				set
				{
					this.monthText = value;
				}
			}

			private bool showDayView = true;

			/// <summary>
			/// True to include the day view (and toolbar button), false to hide them (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowDayView 
			{ 
				get
				{
					return this.showDayView;
				}
				set
				{
					this.showDayView = value;
				}
			}

			private bool showMonthView = true;

			/// <summary>
			/// True to include the month view (and toolbar button), false to hide them (defaults to true). If the day and week views are both hidden, the month view will show by default even if this config is false.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowMonthView 
			{ 
				get
				{
					return this.showMonthView;
				}
				set
				{
					this.showMonthView = value;
				}
			}

			private bool showNavBar = true;

			/// <summary>
			/// True to display the calendar navigation toolbar, false to hide it (defaults to true). Note that if you hide the default navigation toolbar you'll have to provide an alternate means of navigating the calendar.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowNavBar 
			{ 
				get
				{
					return this.showNavBar;
				}
				set
				{
					this.showNavBar = value;
				}
			}

			private bool showTime = true;

			/// <summary>
			/// True to display the current time next to the date in the calendar's current day box, false to not show it (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowTime 
			{ 
				get
				{
					return this.showTime;
				}
				set
				{
					this.showTime = value;
				}
			}

			private bool showTodayText = true;

			/// <summary>
			/// True to show the value of todayText instead of today's date in the calendar's current day box, false to display the day number(defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowTodayText 
			{ 
				get
				{
					return this.showTodayText;
				}
				set
				{
					this.showTodayText = value;
				}
			}

			private bool showWeekView = true;

			/// <summary>
			/// True to include the week view (and toolbar button), false to hide them (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowWeekView 
			{ 
				get
				{
					return this.showWeekView;
				}
				set
				{
					this.showWeekView = value;
				}
			}

			private string todayText = "Today";

			/// <summary>
			/// Alternate text to use for the 'Today' nav bar button.
			/// </summary>
			[DefaultValue("Today")]
			public virtual string TodayText 
			{ 
				get
				{
					return this.todayText;
				}
				set
				{
					this.todayText = value;
				}
			}

			private string weekText = "Week";

			/// <summary>
			/// Alternate text to use for the 'Week' nav bar button.
			/// </summary>
			[DefaultValue("Week")]
			public virtual string WeekText 
			{ 
				get
				{
					return this.weekText;
				}
				set
				{
					this.weekText = value;
				}
			}

			private string calendarStoreID = "";

			/// <summary>
			/// The calendar store ID to use.
			/// </summary>
			[DefaultValue("")]
			public virtual string CalendarStoreID 
			{ 
				get
				{
					return this.calendarStoreID;
				}
				set
				{
					this.calendarStoreID = value;
				}
			}

			private CalendarStore calendarStore = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual CalendarStore CalendarStore 
			{ 
				get
				{
					return this.calendarStore;
				}
				set
				{
					this.calendarStore = value;
				}
			}

			private string eventStoreID = "";

			/// <summary>
			/// The event store ID to use.
			/// </summary>
			[DefaultValue("")]
			public virtual string EventStoreID 
			{ 
				get
				{
					return this.eventStoreID;
				}
				set
				{
					this.eventStoreID = value;
				}
			}

			private EventStore eventStore = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual EventStore EventStore 
			{ 
				get
				{
					return this.eventStore;
				}
				set
				{
					this.eventStore = value;
				}
			}

			private DayView dayView = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DayView DayView 
			{ 
				get
				{
					return this.dayView;
				}
				set
				{
					this.dayView = value;
				}
			}

			private WeekView weekView = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual WeekView WeekView 
			{ 
				get
				{
					return this.weekView;
				}
				set
				{
					this.weekView = value;
				}
			}

			private MonthView monthView = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual MonthView MonthView 
			{ 
				get
				{
					return this.monthView;
				}
				set
				{
					this.monthView = value;
				}
			}

			private EventDetails eventDetails = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual EventDetails EventDetails 
			{ 
				get
				{
					return this.eventDetails;
				}
				set
				{
					this.eventDetails = value;
				}
			}

        }
    }
}