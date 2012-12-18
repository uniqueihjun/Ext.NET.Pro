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
    public partial class MenuSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TMenuSeparator, TBuilder> : MenuItemBase.Builder<TMenuSeparator, TBuilder>
            where TMenuSeparator : MenuSeparator
            where TBuilder : Builder<TMenuSeparator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TMenuSeparator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuSeparator.Builder<MenuSeparator, MenuSeparator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MenuSeparator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuSeparator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MenuSeparator.Config config) : base(new MenuSeparator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MenuSeparator component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MenuSeparator(this);
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
        public MenuSeparator.Builder MenuSeparator()
        {
#if MVC
			return this.MenuSeparator(new MenuSeparator { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.MenuSeparator(new MenuSeparator());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder MenuSeparator(MenuSeparator component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new MenuSeparator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder MenuSeparator(MenuSeparator.Config config)
        {
#if MVC
			return new MenuSeparator.Builder(new MenuSeparator(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new MenuSeparator.Builder(new MenuSeparator(config));
#endif			
        }
    }
}