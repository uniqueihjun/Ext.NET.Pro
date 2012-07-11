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
    public partial class PanelHeader
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public PanelHeader(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit PanelHeader.Config Conversion to PanelHeader
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PanelHeader(PanelHeader.Config config)
        {
            return new PanelHeader(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractContainer.Config 
        { 
			/*  Implicit PanelHeader.Config Conversion to PanelHeader.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator PanelHeader.Builder(PanelHeader.Config config)
			{
				return new PanelHeader.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Icon icon = Icon.None;

			/// <summary>
			/// The icon to use in the Title bar. See also, IconCls to set an icon with a custom Css class.
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
			/// A CSS class that will provide a background image to be used as the panel header icon (defaults to '').
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

			private string iconPath = "";

			/// <summary>
			/// A CSS class that will provide a background image to be used as the panel header icon (defaults to '').
			/// </summary>
			[DefaultValue("")]
			public virtual string IconPath 
			{ 
				get
				{
					return this.iconPath;
				}
				set
				{
					this.iconPath = value;
				}
			}

			private string title = "";

			/// <summary>
			/// Set a title for the panel's header. See Ext.panel.Header.title.
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

			private TitleAlign titleAlign = TitleAlign.Default;

			/// <summary>
			/// May be \"left\", \"right\" or \"center\". The alignment of the title text within the available space between the icon and the tools. Defaults to: \"left\"
			/// </summary>
			[DefaultValue(TitleAlign.Default)]
			public virtual TitleAlign TitleAlign 
			{ 
				get
				{
					return this.titleAlign;
				}
				set
				{
					this.titleAlign = value;
				}
			}
        
			private PanelHeaderListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public PanelHeaderListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new PanelHeaderListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private PanelHeaderDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public PanelHeaderDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new PanelHeaderDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}