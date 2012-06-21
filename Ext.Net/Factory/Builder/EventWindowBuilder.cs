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
    public partial class EventWindow
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : EventWindowBase.Builder<EventWindow, EventWindow.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new EventWindow()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventWindow component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventWindow.Config config) : base(new EventWindow(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(EventWindow component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventWindow.Builder</returns>
            public virtual EventWindow.Builder Listeners(Action<EventWindowListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as EventWindow.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventWindow.Builder</returns>
            public virtual EventWindow.Builder DirectEvents(Action<EventWindowDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as EventWindow.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public EventWindow.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EventWindow(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public EventWindow.Builder EventWindow()
        {
            return this.EventWindow(new EventWindow());
        }

        /// <summary>
        /// 
        /// </summary>
        public EventWindow.Builder EventWindow(EventWindow component)
        {
            return new EventWindow.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EventWindow.Builder EventWindow(EventWindow.Config config)
        {
            return new EventWindow.Builder(new EventWindow(config));
        }
    }
}