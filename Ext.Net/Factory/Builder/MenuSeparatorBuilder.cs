/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class MenuSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseMenuItem.Builder<MenuSeparator, MenuSeparator.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to hide the containing menu after this item is clicked (defaults to true).
			/// </summary>
            public virtual MenuSeparator.Builder HideOnClick(bool hideOnClick)
            {
                this.ToComponent().HideOnClick = hideOnClick;
                return this as MenuSeparator.Builder;
            }
             
 			/// <summary>
			/// Render this component disabled (default is false).
			/// </summary>
            public virtual MenuSeparator.Builder Disabled(bool disabled)
            {
                this.ToComponent().Disabled = disabled;
                return this as MenuSeparator.Builder;
            }
             
 			/// <summary>
			/// The default CSS class to use for text items (defaults to \"x-menu-text\")
			/// </summary>
            public virtual MenuSeparator.Builder ItemCls(string itemCls)
            {
                this.ToComponent().ItemCls = itemCls;
                return this as MenuSeparator.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MenuSeparator(this);
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
            return this.MenuSeparator(new MenuSeparator());
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder MenuSeparator(MenuSeparator component)
        {
            return new MenuSeparator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator.Builder MenuSeparator(MenuSeparator.Config config)
        {
            return new MenuSeparator.Builder(new MenuSeparator(config));
        }
    }
}