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
    public partial class StartMenuConfig
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public StartMenuConfig(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit StartMenuConfig.Config Conversion to StartMenuConfig
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartMenuConfig(StartMenuConfig.Config config)
        {
            return new StartMenuConfig(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit StartMenuConfig.Config Conversion to StartMenuConfig.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator StartMenuConfig.Builder(StartMenuConfig.Config config)
			{
				return new StartMenuConfig.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Icon icon = Icon.None;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(Icon.None)]
			public virtual Icon Icon 
			{ 
				get
				{
					return this.icon;
				}
				set
				{
					this.icon = value;
				}
			}

			private string iconCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string IconCls 
			{ 
				get
				{
					return this.iconCls;
				}
				set
				{
					this.iconCls = value;
				}
			}

			private int width = 300;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(300)]
			public virtual int Width 
			{ 
				get
				{
					return this.width;
				}
				set
				{
					this.width = value;
				}
			}

			private int toolsWidth = 100;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(100)]
			public virtual int ToolsWidth 
			{ 
				get
				{
					return this.toolsWidth;
				}
				set
				{
					this.toolsWidth = value;
				}
			}

			private int height = 300;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(300)]
			public virtual int Height 
			{ 
				get
				{
					return this.height;
				}
				set
				{
					this.height = value;
				}
			}

			private string title = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Title 
			{ 
				get
				{
					return this.title;
				}
				set
				{
					this.title = value;
				}
			}

			private bool shadow = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Shadow 
			{ 
				get
				{
					return this.shadow;
				}
				set
				{
					this.shadow = value;
				}
			}
        
			private ItemsCollection<Component> toolItems = null;

			/// <summary>
			/// Collection of Tool items
			/// </summary>
			public ItemsCollection<Component> ToolItems
			{
				get
				{
					if (this.toolItems == null)
					{
						this.toolItems = new ItemsCollection<Component>();
					}
			
					return this.toolItems;
				}
			}
			        
			private ItemsCollection<Component> items = null;

			/// <summary>
			/// Items collection
			/// </summary>
			public ItemsCollection<Component> Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ItemsCollection<Component>();
					}
			
					return this.items;
				}
			}
			
        }
    }
}