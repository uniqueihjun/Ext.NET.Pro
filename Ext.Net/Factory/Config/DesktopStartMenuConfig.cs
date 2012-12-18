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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DesktopStartMenu(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DesktopStartMenu.Config Conversion to DesktopStartMenu
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DesktopStartMenu(DesktopStartMenu.Config config)
        {
            return new DesktopStartMenu(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Panel.Config 
        { 
			/*  Implicit DesktopStartMenu.Config Conversion to DesktopStartMenu.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DesktopStartMenu.Builder(DesktopStartMenu.Config config)
			{
				return new DesktopStartMenu.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string defaultAlign = "bl-tl";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("bl-tl")]
			public virtual string DefaultAlign 
			{ 
				get
				{
					return this.defaultAlign;
				}
				set
				{
					this.defaultAlign = value;
				}
			}

			private bool hideTools = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideTools 
			{ 
				get
				{
					return this.hideTools;
				}
				set
				{
					this.hideTools = value;
				}
			}
        
			private ItemsCollection<AbstractComponent> menuItems = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<AbstractComponent> MenuItems
			{
				get
				{
					if (this.menuItems == null)
					{
						this.menuItems = new ItemsCollection<AbstractComponent>();
					}
			
					return this.menuItems;
				}
			}
			        
			private ToolbarCollection toolConfig = null;

			/// <summary>
			/// 
			/// </summary>
			public ToolbarCollection ToolConfig
			{
				get
				{
					if (this.toolConfig == null)
					{
						this.toolConfig = new ToolbarCollection();
					}
			
					return this.toolConfig;
				}
			}
			
        }
    }
}