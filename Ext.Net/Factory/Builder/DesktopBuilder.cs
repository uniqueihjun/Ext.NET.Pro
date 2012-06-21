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
    public partial class Desktop
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<Desktop, Desktop.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Desktop()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Desktop component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Desktop.Config config) : base(new Desktop(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Desktop component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Desktop.Builder</returns>
            public virtual Desktop.Builder Modules(Action<DesktopModulesCollection> action)
            {
                action(this.ToComponent().Modules);
                return this as Desktop.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual Desktop.Builder DesktopConfig(DesktopConfig desktopConfig)
            {
                this.ToComponent().DesktopConfig = desktopConfig;
                return this as Desktop.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Desktop.Builder StartMenu(DesktopStartMenu startMenu)
            {
                this.ToComponent().StartMenu = startMenu;
                return this as Desktop.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Desktop.Builder TaskBar(DesktopTaskBar taskBar)
            {
                this.ToComponent().TaskBar = taskBar;
                return this as Desktop.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Desktop.Builder</returns>
            public virtual Desktop.Builder Listeners(Action<DesktopListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Desktop.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Desktop.Builder</returns>
            public virtual Desktop.Builder DirectEvents(Action<DesktopDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Desktop.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Desktop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Desktop(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Desktop.Builder Desktop()
        {
            return this.Desktop(new Desktop());
        }

        /// <summary>
        /// 
        /// </summary>
        public Desktop.Builder Desktop(Desktop component)
        {
            return new Desktop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Desktop.Builder Desktop(Desktop.Config config)
        {
            return new Desktop.Builder(new Desktop(config));
        }
    }
}