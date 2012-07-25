/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class CalendarPanel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CalendarPanelBase.Builder<CalendarPanel, CalendarPanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CalendarPanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarPanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarPanel.Config config) : base(new CalendarPanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CalendarPanel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CalendarPanel.Builder</returns>
            public virtual CalendarPanel.Builder Listeners(Action<CalendarPanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CalendarPanel.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CalendarPanel.Builder</returns>
            public virtual CalendarPanel.Builder DirectEvents(Action<CalendarPanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as CalendarPanel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarPanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder CalendarPanel()
        {
            return this.CalendarPanel(new CalendarPanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder CalendarPanel(CalendarPanel component)
        {
            return new CalendarPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder CalendarPanel(CalendarPanel.Config config)
        {
            return new CalendarPanel.Builder(new CalendarPanel(config));
        }
    }
}