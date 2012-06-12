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
    public partial class DesktopShortcut
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DesktopShortcut(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DesktopShortcut.Config Conversion to DesktopShortcut
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DesktopShortcut(DesktopShortcut.Config config)
        {
            return new DesktopShortcut(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit DesktopShortcut.Config Conversion to DesktopShortcut.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DesktopShortcut.Builder(DesktopShortcut.Config config)
			{
				return new DesktopShortcut.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string moduleID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ModuleID 
			{ 
				get
				{
					return this.moduleID;
				}
				set
				{
					this.moduleID = value;
				}
			}

			private string shortcutID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ShortcutID 
			{ 
				get
				{
					return this.shortcutID;
				}
				set
				{
					this.shortcutID = value;
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

			private string x = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string X 
			{ 
				get
				{
					return this.x;
				}
				set
				{
					this.x = value;
				}
			}

			private string y = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Y 
			{ 
				get
				{
					return this.y;
				}
				set
				{
					this.y = value;
				}
			}

        }
    }
}