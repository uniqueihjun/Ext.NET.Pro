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
    public partial class TabMenu
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Plugin.Builder<TabMenu, TabMenu.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TabMenu()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabMenu component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabMenu.Config config) : base(new TabMenu(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TabMenu component)
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
        public TabMenu.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TabMenu(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TabMenu.Builder TabMenu()
        {
            return this.TabMenu(new TabMenu());
        }

        /// <summary>
        /// 
        /// </summary>
        public TabMenu.Builder TabMenu(TabMenu component)
        {
            return new TabMenu.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TabMenu.Builder TabMenu(TabMenu.Config config)
        {
            return new TabMenu.Builder(new TabMenu(config));
        }
    }
}