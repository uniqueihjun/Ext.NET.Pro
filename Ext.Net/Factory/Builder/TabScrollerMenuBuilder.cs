/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class TabScrollerMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<TabScrollerMenu, TabScrollerMenu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TabScrollerMenu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabScrollerMenu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabScrollerMenu.Config config) : base(new TabScrollerMenu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TabScrollerMenu component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The page size.
			/// </summary>
            public virtual TabScrollerMenu.Builder PageSize(int pageSize)
            {
                this.ToComponent().PageSize = pageSize;
                return this as TabScrollerMenu.Builder;
            }
             
 			/// <summary>
			/// The maximum text length to truncate.
			/// </summary>
            public virtual TabScrollerMenu.Builder MaxText(int maxText)
            {
                this.ToComponent().MaxText = maxText;
                return this as TabScrollerMenu.Builder;
            }
             
 			/// <summary>
			/// Menu prefix text.
			/// </summary>
            public virtual TabScrollerMenu.Builder MenuPrefixText(string menuPrefixText)
            {
                this.ToComponent().MenuPrefixText = menuPrefixText;
                return this as TabScrollerMenu.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TabScrollerMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TabScrollerMenu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TabScrollerMenu.Builder TabScrollerMenu()
        {
            return this.TabScrollerMenu(new TabScrollerMenu());
        }

        /// <summary>
        /// 
        /// </summary>
        public TabScrollerMenu.Builder TabScrollerMenu(TabScrollerMenu component)
        {
            return new TabScrollerMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TabScrollerMenu.Builder TabScrollerMenu(TabScrollerMenu.Config config)
        {
            return new TabScrollerMenu.Builder(new TabScrollerMenu(config));
        }
    }
}