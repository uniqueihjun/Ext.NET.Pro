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
    public partial class Menu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuBase.Builder<Menu, Menu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Menu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Menu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Menu.Config config) : base(new Menu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Menu component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Menu.Builder</returns>
            public virtual Menu.Builder Listeners(Action<MenuListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Menu.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Menu.Builder</returns>
            public virtual Menu.Builder DirectEvents(Action<MenuDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Menu.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Menu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Menu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Menu.Builder Menu()
        {
            return this.Menu(new Menu());
        }

        /// <summary>
        /// 
        /// </summary>
        public Menu.Builder Menu(Menu component)
        {
            return new Menu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Menu.Builder Menu(Menu.Config config)
        {
            return new Menu.Builder(new Menu(config));
        }
    }
}