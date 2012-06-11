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
    public partial class Window
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractWindow.Builder<Window, Window.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Window()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Window component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Window.Config config) : base(new Window(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Window component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Window.Builder</returns>
            public virtual Window.Builder Listeners(Action<WindowListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Window.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Window.Builder</returns>
            public virtual Window.Builder DirectEvents(Action<WindowDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Window.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Window.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Window(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Window.Builder Window()
        {
            return this.Window(new Window());
        }

        /// <summary>
        /// 
        /// </summary>
        public Window.Builder Window(Window component)
        {
            return new Window.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Window.Builder Window(Window.Config config)
        {
            return new Window.Builder(new Window(config));
        }
    }
}