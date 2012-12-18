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
    public partial class GroupTabPanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GroupTabPanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GroupTabPanel.Config Conversion to GroupTabPanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GroupTabPanel(GroupTabPanel.Config config)
        {
            return new GroupTabPanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractContainer.Config 
        { 
			/*  Implicit GroupTabPanel.Config Conversion to GroupTabPanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GroupTabPanel.Builder(GroupTabPanel.Config config)
			{
				return new GroupTabPanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool deferredRender = false;

			/// <summary>
			/// Deferred Render
			/// </summary>
			[DefaultValue(false)]
			public virtual bool DeferredRender 
			{ 
				get
				{
					return this.deferredRender;
				}
				set
				{
					this.deferredRender = value;
				}
			}

			private string activeGroup = "";

			/// <summary>
			/// Active group
			/// </summary>
			[DefaultValue("")]
			public virtual string ActiveGroup 
			{ 
				get
				{
					return this.activeGroup;
				}
				set
				{
					this.activeGroup = value;
				}
			}

			private int activeGroupIndex = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int ActiveGroupIndex 
			{ 
				get
				{
					return this.activeGroupIndex;
				}
				set
				{
					this.activeGroupIndex = value;
				}
			}

			private string activeTab = "";

			/// <summary>
			/// Active tab
			/// </summary>
			[DefaultValue("")]
			public virtual string ActiveTab 
			{ 
				get
				{
					return this.activeTab;
				}
				set
				{
					this.activeTab = value;
				}
			}

			private int activeTabIndex = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int ActiveTabIndex 
			{ 
				get
				{
					return this.activeTabIndex;
				}
				set
				{
					this.activeTabIndex = value;
				}
			}

			private Unit tabWidth = Unit.Pixel(120);

			/// <summary>
			/// The initial width in pixels of each new tab (defaults to 120).
			/// </summary>
			[DefaultValue(typeof(Unit), "120")]
			public virtual Unit TabWidth 
			{ 
				get
				{
					return this.tabWidth;
				}
				set
				{
					this.tabWidth = value;
				}
			}
        
			private GroupTabPanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public GroupTabPanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new GroupTabPanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private GroupTabPanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public GroupTabPanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new GroupTabPanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}