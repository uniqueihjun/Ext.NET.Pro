/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class TimePicker
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BoundListBase.Builder<TimePicker, TimePicker.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TimePicker()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TimePicker component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TimePicker.Config config) : base(new TimePicker(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TimePicker component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TimePicker.Builder PostBackEvent(string postBackEvent)
            {
                this.ToComponent().PostBackEvent = postBackEvent;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// AutoPostBack
			/// </summary>
            public virtual TimePicker.Builder AutoPostBack(bool autoPostBack)
            {
                this.ToComponent().AutoPostBack = autoPostBack;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// Gets or sets a value indicating whether validation is performed when the control is set to validate when a postback occurs.
			/// </summary>
            public virtual TimePicker.Builder CausesValidation(bool causesValidation)
            {
                this.ToComponent().CausesValidation = causesValidation;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// Gets or Sets the Controls ValidationGroup
			/// </summary>
            public virtual TimePicker.Builder ValidationGroup(string validationGroup)
            {
                this.ToComponent().ValidationGroup = validationGroup;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TimePicker.Builder SelectedTime(TimeSpan selectedTime)
            {
                this.ToComponent().SelectedTime = selectedTime;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// The default time format string which can be overriden for localization support. The format must be valid according to Ext.Date.parse (defaults to 'g:i A', e.g., '3:15 PM'). For 24-hour time format try 'H:i' instead.
			/// </summary>
            public virtual TimePicker.Builder Format(string format)
            {
                this.ToComponent().Format = format;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// The number of minutes between each time value in the list (defaults to 15).
			/// </summary>
            public virtual TimePicker.Builder Increment(int increment)
            {
                this.ToComponent().Increment = increment;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// The maximum allowed time. Can be either a Javascript date object with a valid time value or a string time in a valid format -- see format and altFormats (defaults to undefined).
			/// </summary>
            public virtual TimePicker.Builder MaxTime(TimeSpan maxTime)
            {
                this.ToComponent().MaxTime = maxTime;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// The minimum allowed time. Can be either a Javascript date object with a valid time value or a string time in a valid format -- see format and altFormats (defaults to undefined).
			/// </summary>
            public virtual TimePicker.Builder MinTime(TimeSpan minTime)
            {
                this.ToComponent().MinTime = minTime;
                return this as TimePicker.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TimePicker.Builder</returns>
            public virtual TimePicker.Builder Listeners(Action<DataViewListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TimePicker.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TimePicker.Builder</returns>
            public virtual TimePicker.Builder DirectEvents(Action<DataViewDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TimePicker.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TimePicker.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TimePicker(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TimePicker.Builder TimePicker()
        {
            return this.TimePicker(new TimePicker());
        }

        /// <summary>
        /// 
        /// </summary>
        public TimePicker.Builder TimePicker(TimePicker component)
        {
            return new TimePicker.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TimePicker.Builder TimePicker(TimePicker.Config config)
        {
            return new TimePicker.Builder(new TimePicker(config));
        }
    }
}