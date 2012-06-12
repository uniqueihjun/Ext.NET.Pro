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
    public partial class Desktop
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Desktop(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Desktop.Config Conversion to Desktop
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Desktop(Desktop.Config config)
        {
            return new Desktop(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Component.Config 
        { 
			/*  Implicit Desktop.Config Conversion to Desktop.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Desktop.Builder(Desktop.Config config)
			{
				return new Desktop.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private DesktopModulesCollection modules = null;

			/// <summary>
			/// 
			/// </summary>
			public DesktopModulesCollection Modules
			{
				get
				{
					if (this.modules == null)
					{
						this.modules = new DesktopModulesCollection();
					}
			
					return this.modules;
				}
			}
			        
			private DesktopShortcuts shortcuts = null;

			/// <summary>
			/// 
			/// </summary>
			public DesktopShortcuts Shortcuts
			{
				get
				{
					if (this.shortcuts == null)
					{
						this.shortcuts = new DesktopShortcuts();
					}
			
					return this.shortcuts;
				}
			}
			
			private int xTickSize = 1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1)]
			public virtual int XTickSize 
			{ 
				get
				{
					return this.xTickSize;
				}
				set
				{
					this.xTickSize = value;
				}
			}

			private int yTickSize = 1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1)]
			public virtual int YTickSize 
			{ 
				get
				{
					return this.yTickSize;
				}
				set
				{
					this.yTickSize = value;
				}
			}

			private string backgroundColor = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string BackgroundColor 
			{ 
				get
				{
					return this.backgroundColor;
				}
				set
				{
					this.backgroundColor = value;
				}
			}

			private string shortcutTextColor = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ShortcutTextColor 
			{ 
				get
				{
					return this.shortcutTextColor;
				}
				set
				{
					this.shortcutTextColor = value;
				}
			}

			private string wallpaper = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Wallpaper 
			{ 
				get
				{
					return this.wallpaper;
				}
				set
				{
					this.wallpaper = value;
				}
			}

			private int textLengthToTruncate = 12;

			/// <summary>
			/// The maximum length of Ext.ux.TaskBar.TaskButton's text to allow before truncating
			/// </summary>
			[DefaultValue(12)]
			public virtual int TextLengthToTruncate 
			{ 
				get
				{
					return this.textLengthToTruncate;
				}
				set
				{
					this.textLengthToTruncate = value;
				}
			}
        
			private DesktopListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DesktopListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DesktopListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DesktopDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public DesktopDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DesktopDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}