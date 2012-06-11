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
    public partial class CalendarStore
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CalendarStore(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CalendarStore.Config Conversion to CalendarStore
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CalendarStore(CalendarStore.Config config)
        {
            return new CalendarStore(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Store.Config 
        { 
			/*  Implicit CalendarStore.Config Conversion to CalendarStore.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CalendarStore.Builder(CalendarStore.Config config)
			{
				return new CalendarStore.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private CalendarModelCollection calendars = null;

			/// <summary>
			/// 
			/// </summary>
			public CalendarModelCollection Calendars
			{
				get
				{
					if (this.calendars == null)
					{
						this.calendars = new CalendarModelCollection();
					}
			
					return this.calendars;
				}
			}
			
        }
    }
}