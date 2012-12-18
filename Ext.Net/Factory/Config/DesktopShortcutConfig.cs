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
        new public partial class Config : BaseItem.Config 
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

			private int sortIndex = -1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(-1)]
			public virtual int SortIndex 
			{ 
				get
				{
					return this.sortIndex;
				}
				set
				{
					this.sortIndex = value;
				}
			}

			private string name = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
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

			private string textCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string TextCls 
			{ 
				get
				{
					return this.textCls;
				}
				set
				{
					this.textCls = value;
				}
			}

			private string handler = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Handler 
			{ 
				get
				{
					return this.handler;
				}
				set
				{
					this.handler = value;
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

			private string module = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Module 
			{ 
				get
				{
					return this.module;
				}
				set
				{
					this.module = value;
				}
			}

			private string qTitle = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string QTitle 
			{ 
				get
				{
					return this.qTitle;
				}
				set
				{
					this.qTitle = value;
				}
			}

			private string qTip = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string QTip 
			{ 
				get
				{
					return this.qTip;
				}
				set
				{
					this.qTip = value;
				}
			}

        }
    }
}