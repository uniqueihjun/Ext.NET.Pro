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
    public partial class Window
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Window(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Window.Config Conversion to Window
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Window(Window.Config config)
        {
            return new Window(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractWindow.Config 
        { 
			/*  Implicit Window.Config Conversion to Window.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Window.Builder(Window.Config config)
			{
				return new Window.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private WindowListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public WindowListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new WindowListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private WindowDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public WindowDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new WindowDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}