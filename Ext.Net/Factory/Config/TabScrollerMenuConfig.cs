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
    public partial class TabScrollerMenu
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TabScrollerMenu(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TabScrollerMenu.Config Conversion to TabScrollerMenu
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TabScrollerMenu(TabScrollerMenu.Config config)
        {
            return new TabScrollerMenu(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit TabScrollerMenu.Config Conversion to TabScrollerMenu.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TabScrollerMenu.Builder(TabScrollerMenu.Config config)
			{
				return new TabScrollerMenu.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int pageSize = 10;

			/// <summary>
			/// The page size.
			/// </summary>
			[DefaultValue(10)]
			public virtual int PageSize 
			{ 
				get
				{
					return this.pageSize;
				}
				set
				{
					this.pageSize = value;
				}
			}

			private int maxText = 15;

			/// <summary>
			/// The maximum text length to truncate.
			/// </summary>
			[DefaultValue(15)]
			public virtual int MaxText 
			{ 
				get
				{
					return this.maxText;
				}
				set
				{
					this.maxText = value;
				}
			}

			private string menuPrefixText = "Items";

			/// <summary>
			/// Menu prefix text.
			/// </summary>
			[DefaultValue("Items")]
			public virtual string MenuPrefixText 
			{ 
				get
				{
					return this.menuPrefixText;
				}
				set
				{
					this.menuPrefixText = value;
				}
			}

        }
    }
}