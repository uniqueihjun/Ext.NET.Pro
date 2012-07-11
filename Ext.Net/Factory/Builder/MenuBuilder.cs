/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(MenuListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(MenuDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

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