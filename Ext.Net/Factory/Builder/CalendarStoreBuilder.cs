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
    public partial class CalendarStore
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Store.Builder<CalendarStore, CalendarStore.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CalendarStore.Builder</returns>
            public virtual CalendarStore.Builder Calendars(Action<CalendarModelCollection> action)
            {
                action(this.ToComponent().Calendars);
                return this as CalendarStore.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarStore(this);
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
            return this.CalendarStore(new CalendarStore());
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder CalendarStore(CalendarStore component)
        {
            return new CalendarStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore.Builder CalendarStore(CalendarStore.Config config)
        {
            return new CalendarStore.Builder(new CalendarStore(config));
        }
    }
}