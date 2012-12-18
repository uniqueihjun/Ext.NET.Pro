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
    public partial class CalendarStore
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCalendarStore, TBuilder> : Store.Builder<TCalendarStore, TBuilder>
            where TCalendarStore : CalendarStore
            where TBuilder : Builder<TCalendarStore, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCalendarStore component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Calendars(Action<CalendarModelCollection> action)
            {
                action(this.ToComponent().Calendars);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CalendarStore.Builder<CalendarStore, CalendarStore.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CalendarStore()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarStore component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarStore.Config config) : base(new CalendarStore(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CalendarStore component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarStore(this);
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
        public CalendarStore.Builder CalendarStore()
        {
#if MVC
			return this.CalendarStore(new CalendarStore { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CalendarStore(new CalendarStore());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder CalendarStore(CalendarStore component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CalendarStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder CalendarStore(CalendarStore.Config config)
        {
#if MVC
			return new CalendarStore.Builder(new CalendarStore(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CalendarStore.Builder(new CalendarStore(config));
#endif			
        }
    }
}