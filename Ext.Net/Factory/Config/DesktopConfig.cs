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
        new public partial class Config : Observable.Config 
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
			
			private DesktopConfig desktopConfig = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopConfig DesktopConfig 
			{ 
				get
				{
					return this.desktopConfig;
				}
				set
				{
					this.desktopConfig = value;
				}
			}

			private DesktopStartMenu startMenu = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopStartMenu StartMenu 
			{ 
				get
				{
					return this.startMenu;
				}
				set
				{
					this.startMenu = value;
				}
			}

			private DesktopTaskBar taskBar = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopTaskBar TaskBar 
			{ 
				get
				{
					return this.taskBar;
				}
				set
				{
					this.taskBar = value;
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