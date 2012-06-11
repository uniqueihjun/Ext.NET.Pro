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
    public partial class MenuSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : MenuItemBase.Builder<MenuSeparator, MenuSeparator.Builder>
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