/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class DayView
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Container.Builder<DayView, DayView.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DayView()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DayView component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DayView.Config config) : base(new DayView(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DayView component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The number of days to display in the view (defaults to 1). Only values from 1 to 7 are allowed.
			/// </summary>
            public virtual DayView.Builder DayCount(int dayCount)
            {
                this.ToComponent().DayCount = dayCount;
                return this as DayView.Builder;
            }
             
 			/// <summary>
			/// The text to display inside the drag proxy while dragging over the calendar to create a new event (defaults to 'Create event for {0}' where {0} is a date range supplied by the view)
			/// </summary>
            public virtual DayView.Builder DDCreateEventText(string dDCreateEventText)
            {
                this.ToComponent().DDCreateEventText = dDCreateEventText;
                return this as DayView.Builder;
            }
             
 			/// <summary>
			/// The text to display inside the drag proxy while dragging an event to reposition it (defaults to 'Move event to {0}' where {0} is the updated event start date/time supplied by the view)
			/// </summary>
            public virtual DayView.Builder DDMoveEventText(string dDMoveEventText)
            {
                this.ToComponent().DDMoveEventText = dDMoveEventText;
                return this as DayView.Builder;
            }
             
 			/// <summary>
			/// True to display the current time in today's box in the calendar, false to not display it (defautls to true)
			/// </summary>
            public virtual DayView.Builder ShowTime(bool showTime)
            {
                this.ToComponent().ShowTime = showTime;
                return this as DayView.Builder;
            }
             
 			/// <summary>
			/// True to display the todayText string in today's box in the calendar, false to not display it (defautls to true)
			/// </summary>
            public virtual DayView.Builder ShowTodayText(bool showTodayText)
            {
                this.ToComponent().ShowTodayText = showTodayText;
                return this as DayView.Builder;
            }
             
 			/// <summary>
			/// The text to display in the current day's box in the calendar when showTodayText is true (defaults to 'Today')
			/// </summary>
            public virtual DayView.Builder TodayText(string todayText)
            {
                this.ToComponent().TodayText = todayText;
                return this as DayView.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DayView.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DayView(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DayView.Builder DayView()
        {
            return this.DayView(new DayView());
        }

        /// <summary>
        /// 
        /// </summary>
        public DayView.Builder DayView(DayView component)
        {
            return new DayView.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DayView.Builder DayView(DayView.Config config)
        {
            return new DayView.Builder(new DayView(config));
        }
    }
}