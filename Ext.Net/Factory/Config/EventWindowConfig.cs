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
    public partial class EventWindow
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public EventWindow(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit EventWindow.Config Conversion to EventWindow
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventWindow(EventWindow.Config config)
        {
            return new EventWindow(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : EventWindowBase.Config 
        { 
			/*  Implicit EventWindow.Config Conversion to EventWindow.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator EventWindow.Builder(EventWindow.Config config)
			{
				return new EventWindow.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private EventWindowListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public EventWindowListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new EventWindowListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private EventWindowDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public EventWindowDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new EventWindowDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}