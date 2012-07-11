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
    public partial class DesktopStartMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Panel.Builder<DesktopStartMenu, DesktopStartMenu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DesktopStartMenu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopStartMenu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopStartMenu.Config config) : base(new DesktopStartMenu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DesktopStartMenu component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopStartMenu.Builder DefaultAlign(string defaultAlign)
            {
                this.ToComponent().DefaultAlign = defaultAlign;
                return this as DesktopStartMenu.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopStartMenu.Builder HideTools(bool hideTools)
            {
                this.ToComponent().HideTools = hideTools;
                return this as DesktopStartMenu.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopStartMenu.Builder</returns>
            public virtual DesktopStartMenu.Builder MenuItems(Action<ItemsCollection<AbstractComponent>> action)
            {
                action(this.ToComponent().MenuItems);
                return this as DesktopStartMenu.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopStartMenu.Builder</returns>
            public virtual DesktopStartMenu.Builder ToolConfig(Action<ToolbarCollection> action)
            {
                action(this.ToComponent().ToolConfig);
                return this as DesktopStartMenu.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DesktopStartMenu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder DesktopStartMenu()
        {
            return this.DesktopStartMenu(new DesktopStartMenu());
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder DesktopStartMenu(DesktopStartMenu component)
        {
            return new DesktopStartMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder DesktopStartMenu(DesktopStartMenu.Config config)
        {
            return new DesktopStartMenu.Builder(new DesktopStartMenu(config));
        }
    }
}