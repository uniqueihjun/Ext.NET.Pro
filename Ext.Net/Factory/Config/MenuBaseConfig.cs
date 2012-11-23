/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class MenuBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractPanel.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool allowOtherMenus = false;

			/// <summary>
			/// True to allow multiple menus to be displayed at the same time (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowOtherMenus 
			{ 
				get
				{
					return this.allowOtherMenus;
				}
				set
				{
					this.allowOtherMenus = value;
				}
			}

			private string defaultAlign = "tl-bl?";

			/// <summary>
			/// The default Ext.Element#getAlignToXY anchor position value for this menu relative to its element of origin. Defaults to: \"tl-bl?\"
			/// </summary>
			[DefaultValue("tl-bl?")]
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

			private bool ignoreParentClicks = false;

			/// <summary>
			/// True to ignore clicks on any item in this menu that is a parent item (displays a submenu) so that the submenu is not dismissed when clicking the parent item. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool IgnoreParentClicks 
			{ 
				get
				{
					return this.ignoreParentClicks;
				}
				set
				{
					this.ignoreParentClicks = value;
				}
			}

			private bool plain = false;

			/// <summary>
			/// True to remove the incised line down the left side of the menu and to not indent general Component items. Defaults to: false
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

			private bool showSeparator = true;

			/// <summary>
			/// True to show the icon separator. (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowSeparator 
			{ 
				get
				{
					return this.showSeparator;
				}
				set
				{
					this.showSeparator = value;
				}
			}

			private bool enableKeyNav = true;

			/// <summary>
			/// True to enable keyboard navigation for controlling the menu. This option should generally be disabled when form fields are being used inside the menu. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool EnableKeyNav 
			{ 
				get
				{
					return this.enableKeyNav;
				}
				set
				{
					this.enableKeyNav = value;
				}
			}

			private bool renderToForm = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RenderToForm 
			{ 
				get
				{
					return this.renderToForm;
				}
				set
				{
					this.renderToForm = value;
				}
			}

        }
    }
}