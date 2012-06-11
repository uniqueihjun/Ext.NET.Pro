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
    public partial class MenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuItemBase.Builder<MenuItem, MenuItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MenuItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuItem.Config config) : base(new MenuItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MenuItem component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MenuItem.Builder</returns>
            public virtual MenuItem.Builder Listeners(Action<MenuItemListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as MenuItem.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of MenuItem.Builder</returns>
            public virtual MenuItem.Builder DirectEvents(Action<MenuItemDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as MenuItem.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MenuItem(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MenuItem.Builder MenuItem()
        {
            return this.MenuItem(new MenuItem());
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuItem.Builder MenuItem(MenuItem component)
        {
            return new MenuItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuItem.Builder MenuItem(MenuItem.Config config)
        {
            return new MenuItem.Builder(new MenuItem(config));
        }
    }
}