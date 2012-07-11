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
			 
 			// /// <summary>
			// /// The ColorPalette object
			// /// </summary>
            // public virtual TBuilder Palette(ColorPalette palette)
            // {
            //    this.ToComponent().Palette = palette;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(ColorMenuListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(ColorMenuDirectEvents directEvents)
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