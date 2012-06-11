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
    public partial class ColorMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuBase.Builder<ColorMenu, ColorMenu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ColorMenu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColorMenu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColorMenu.Config config) : base(new ColorMenu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ColorMenu component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The ColorPalette object
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ColorMenu.Builder</returns>
            public virtual ColorMenu.Builder Picker(Action<ColorPicker> action)
            {
                action(this.ToComponent().Picker);
                return this as ColorMenu.Builder;
            }
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ColorMenu.Builder</returns>
            public virtual ColorMenu.Builder Listeners(Action<ColorMenuListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as ColorMenu.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ColorMenu.Builder</returns>
            public virtual ColorMenu.Builder DirectEvents(Action<ColorMenuDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as ColorMenu.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ColorMenu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ColorMenu.Builder ColorMenu()
        {
            return this.ColorMenu(new ColorMenu());
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorMenu.Builder ColorMenu(ColorMenu component)
        {
            return new ColorMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ColorMenu.Builder ColorMenu(ColorMenu.Config config)
        {
            return new ColorMenu.Builder(new ColorMenu(config));
        }
    }
}