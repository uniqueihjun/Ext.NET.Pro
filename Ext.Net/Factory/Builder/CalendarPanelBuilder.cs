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
        new public abstract partial class Builder<TCalendarPanel, TBuilder> : CalendarPanelBase.Builder<TCalendarPanel, TBuilder>
            where TCalendarPanel : CalendarPanel
            where TBuilder : Builder<TCalendarPanel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCalendarPanel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CalendarPanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CalendarPanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CalendarPanel.Builder<CalendarPanel, CalendarPanel.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarPanel(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.CalendarPanel(new CalendarPanel { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CalendarPanel(new CalendarPanel());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder CalendarPanel(CalendarPanel component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CalendarPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel.Builder CalendarPanel(CalendarPanel.Config config)
        {
#if MVC
			return new CalendarPanel.Builder(new CalendarPanel(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CalendarPanel.Builder(new CalendarPanel(config));
#endif			
        }
    }
}