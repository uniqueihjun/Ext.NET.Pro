/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
        new public abstract partial class Builder<TDesktopStartMenu, TBuilder> : Panel.Builder<TDesktopStartMenu, TBuilder>
            where TDesktopStartMenu : DesktopStartMenu
            where TBuilder : Builder<TDesktopStartMenu, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDesktopStartMenu component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DefaultAlign(string defaultAlign)
            {
                this.ToComponent().DefaultAlign = defaultAlign;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder HideTools(bool hideTools)
            {
                this.ToComponent().HideTools = hideTools;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder MenuItems(Action<ItemsCollection<AbstractComponent>> action)
            {
                action(this.ToComponent().MenuItems);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder ToolConfig(Action<ToolbarCollection> action)
            {
                action(this.ToComponent().ToolConfig);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DesktopStartMenu.Builder<DesktopStartMenu, DesktopStartMenu.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DesktopStartMenu(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.DesktopStartMenu(new DesktopStartMenu { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DesktopStartMenu(new DesktopStartMenu());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder DesktopStartMenu(DesktopStartMenu component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DesktopStartMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu.Builder DesktopStartMenu(DesktopStartMenu.Config config)
        {
#if MVC
			return new DesktopStartMenu.Builder(new DesktopStartMenu(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DesktopStartMenu.Builder(new DesktopStartMenu(config));
#endif			
        }
    }
}