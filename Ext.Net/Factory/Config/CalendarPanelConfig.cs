/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class CalendarPanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CalendarPanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CalendarPanel.Config Conversion to CalendarPanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CalendarPanel(CalendarPanel.Config config)
        {
            return new CalendarPanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : CalendarPanelBase.Config 
        { 
			/*  Implicit CalendarPanel.Config Conversion to CalendarPanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CalendarPanel.Builder(CalendarPanel.Config config)
			{
				return new CalendarPanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private CalendarPanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public CalendarPanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new CalendarPanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private CalendarPanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public CalendarPanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new CalendarPanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}