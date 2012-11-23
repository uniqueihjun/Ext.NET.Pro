/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class EventDetails
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public EventDetails(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit EventDetails.Config Conversion to EventDetails
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventDetails(EventDetails.Config config)
        {
            return new EventDetails(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : EventDetailsBase.Config 
        { 
			/*  Implicit EventDetails.Config Conversion to EventDetails.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator EventDetails.Builder(EventDetails.Config config)
			{
				return new EventDetails.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private EventDetailsListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public EventDetailsListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new EventDetailsListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private EventDetailsDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public EventDetailsDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new EventDetailsDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}