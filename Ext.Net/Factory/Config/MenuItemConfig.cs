/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class MenuItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MenuItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MenuItem.Config Conversion to MenuItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MenuItem(MenuItem.Config config)
        {
            return new MenuItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MenuItemBase.Config 
        { 
			/*  Implicit MenuItem.Config Conversion to MenuItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MenuItem.Builder(MenuItem.Config config)
			{
				return new MenuItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private MenuItemListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public MenuItemListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new MenuItemListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private MenuItemDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public MenuItemDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new MenuItemDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}