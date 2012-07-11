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
    public abstract partial class ImageCommandBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : StateManagedItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string commandName = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string CommandName 
			{ 
				get
				{
					return this.commandName;
				}
				set
				{
					this.commandName = value;
				}
			}

			private string cls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Cls 
			{ 
				get
				{
					return this.cls;
				}
				set
				{
					this.cls = value;
				}
			}

			private bool hidden = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Hidden 
			{ 
				get
				{
					return this.hidden;
				}
				set
				{
					this.hidden = value;
				}
			}

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

			private string text = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
				}
			}

			private string style = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Style 
			{ 
				get
				{
					return this.style;
				}
				set
				{
					this.style = value;
				}
			}
        
			private SimpleToolTip toolTip = null;

			/// <summary>
			/// 
			/// </summary>
			public SimpleToolTip ToolTip
			{
				get
				{
					if (this.toolTip == null)
					{
						this.toolTip = new SimpleToolTip();
					}
			
					return this.toolTip;
				}
			}
			
			private HideMode hideMode = HideMode.Display;

			/// <summary>
			/// How this component should be hidden. Supported values are 'visibility' (css visibility), 'offsets' (negative offset position) and 'display' (css display) - defaults to 'display'.
			/// </summary>
			[DefaultValue(HideMode.Display)]
			public virtual HideMode HideMode 
			{ 
				get
				{
					return this.hideMode;
				}
				set
				{
					this.hideMode = value;
				}
			}

        }
    }
}