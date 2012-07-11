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
    public partial class MenuSeparator
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MenuSeparator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MenuSeparator.Config Conversion to MenuSeparator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MenuSeparator(MenuSeparator.Config config)
        {
            return new MenuSeparator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseMenuItem.Config 
        { 
			/*  Implicit MenuSeparator.Config Conversion to MenuSeparator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MenuSeparator.Builder(MenuSeparator.Config config)
			{
				return new MenuSeparator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool hideOnClick = false;

			/// <summary>
			/// True to hide the containing menu after this item is clicked (defaults to true).
			/// </summary>
			[DefaultValue(false)]
			public override bool HideOnClick 
			{ 
				get
				{
					return this.hideOnClick;
				}
				set
				{
					this.hideOnClick = value;
				}
			}

			private bool disabled = true;

			/// <summary>
			/// Render this component disabled (default is false).
			/// </summary>
			[DefaultValue(true)]
			public override bool Disabled 
			{ 
				get
				{
					return this.disabled;
				}
				set
				{
					this.disabled = value;
				}
			}

			private string itemCls = "";

			/// <summary>
			/// The default CSS class to use for text items (defaults to \"x-menu-text\")
			/// </summary>
			[DefaultValue("")]
			public override string ItemCls 
			{ 
				get
				{
					return this.itemCls;
				}
				set
				{
					this.itemCls = value;
				}
			}

        }
    }
}