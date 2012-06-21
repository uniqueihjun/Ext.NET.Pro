/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public abstract partial class AbstractTabPanel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractPanel.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private AbstractComponent activeTab = null;

			/// <summary>
			/// The numeric index of the tab that should be initially activated on render.
			/// </summary>
			[DefaultValue(null)]
			public virtual AbstractComponent ActiveTab 
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
			/// The numeric index of the tab that should be initially activated on render.
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

			private bool deferredRender = true;

			/// <summary>
			/// True by default to defer the rendering of child items to the browsers DOM until a tab is activated.
			/// </summary>
			[DefaultValue(true)]
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

			private int minTabWidth = 0;

			/// <summary>
			/// The minimum width for a tab in the tabBar.
			/// </summary>
			[DefaultValue(0)]
			public virtual int MinTabWidth 
			{ 
				get
				{
					return this.minTabWidth;
				}
				set
				{
					this.minTabWidth = value;
				}
			}

			private int maxTabWidth = int.MaxValue;

			/// <summary>
			/// The maximum width for each tab.
			/// </summary>
			[DefaultValue(int.MaxValue)]
			public virtual int MaxTabWidth 
			{ 
				get
				{
					return this.maxTabWidth;
				}
				set
				{
					this.maxTabWidth = value;
				}
			}

			private bool plain = false;

			/// <summary>
			/// True to not show the full background on the TabBar. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Plain 
			{ 
				get
				{
					return this.plain;
				}
				set
				{
					this.plain = value;
				}
			}

			private TabAlign tabAlign = TabAlign.Left;

			/// <summary>
			/// The alignment of the Tabs (defaults to 'Left'). Other option includes 'Right'. Note that tab scrolling is only supported for TabAlign='Left'. Note that when 'Right', the Tabs will be rendered in reverse order.
			/// </summary>
			[DefaultValue(TabAlign.Left)]
			public virtual TabAlign TabAlign 
			{ 
				get
				{
					return this.tabAlign;
				}
				set
				{
					this.tabAlign = value;
				}
			}
        
			private ItemsCollection<AbstractComponent> tabBar = null;

			/// <summary>
			/// Optional items for the internal Ext.tab.Bar. If present, this is passed straight through to the TabBar's constructor.
			/// </summary>
			public ItemsCollection<AbstractComponent> TabBar
			{
				get
				{
					if (this.tabBar == null)
					{
						this.tabBar = new ItemsCollection<AbstractComponent>();
					}
			
					return this.tabBar;
				}
			}
			
			private string itemCls = "";

			/// <summary>
			/// The class added to each child item of this TabPanel. Defaults to: \"x-tabpanel-child\"
			/// </summary>
			[DefaultValue("")]
			public virtual string ItemCls 
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

			private bool removePanelHeader = true;

			/// <summary>
			/// True to instruct each Panel added to the TabContainer to not render its header element. This is to ensure that the title of the panel does not appear twice. Defaults to: true
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RemovePanelHeader 
			{ 
				get
				{
					return this.removePanelHeader;
				}
				set
				{
					this.removePanelHeader = value;
				}
			}

			private TabPosition tabPosition = TabPosition.Top;

			/// <summary>
			/// The position where the tab strip should be rendered. Can be top or bottom. Defaults to: \"top\"
			/// </summary>
			[DefaultValue(TabPosition.Top)]
			public virtual TabPosition TabPosition 
			{ 
				get
				{
					return this.tabPosition;
				}
				set
				{
					this.tabPosition = value;
				}
			}
        
			private MenuCollection defaultTabMenu = null;

			/// <summary>
			/// Default menu for all tabs
			/// </summary>
			public MenuCollection DefaultTabMenu
			{
				get
				{
					if (this.defaultTabMenu == null)
					{
						this.defaultTabMenu = new MenuCollection();
					}
			
					return this.defaultTabMenu;
				}
			}
			
			private bool autoPostBack = false;

			/// <summary>
			/// Gets or sets a value indicating whether the control state automatically posts back to the server when tab changed.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AutoPostBack 
			{ 
				get
				{
					return this.autoPostBack;
				}
				set
				{
					this.autoPostBack = value;
				}
			}

			private string postBackEvent = "beforetabchange";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("beforetabchange")]
			public virtual string PostBackEvent 
			{ 
				get
				{
					return this.postBackEvent;
				}
				set
				{
					this.postBackEvent = value;
				}
			}

			private bool causesValidation = false;

			/// <summary>
			/// Gets or sets a value indicating whether validation is performed when the control is set to validate when a postback occurs.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CausesValidation 
			{ 
				get
				{
					return this.causesValidation;
				}
				set
				{
					this.causesValidation = value;
				}
			}

			private string validationGroup = "";

			/// <summary>
			/// Gets or Sets the Controls ValidationGroup
			/// </summary>
			[DefaultValue("")]
			public virtual string ValidationGroup 
			{ 
				get
				{
					return this.validationGroup;
				}
				set
				{
					this.validationGroup = value;
				}
			}

        }
    }
}