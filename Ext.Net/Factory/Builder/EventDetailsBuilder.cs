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
    public partial class EventDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : EventDetailsBase.Builder<EventDetails, EventDetails.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new EventDetails()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventDetails component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventDetails.Config config) : base(new EventDetails(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(EventDetails component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventDetails.Builder</returns>
            public virtual EventDetails.Builder Listeners(Action<EventDetailsListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as EventDetails.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventDetails.Builder</returns>
            public virtual EventDetails.Builder DirectEvents(Action<EventDetailsDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as EventDetails.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EventDetails(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder EventDetails()
        {
            return this.EventDetails(new EventDetails());
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder EventDetails(EventDetails component)
        {
            return new EventDetails.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder EventDetails(EventDetails.Config config)
        {
            return new EventDetails.Builder(new EventDetails(config));
        }
    }
}