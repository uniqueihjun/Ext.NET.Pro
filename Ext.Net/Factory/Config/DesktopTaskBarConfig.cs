/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class DesktopTaskBar
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DesktopTaskBar.Config Conversion to DesktopTaskBar
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DesktopTaskBar(DesktopTaskBar.Config config)
        {
            return new DesktopTaskBar(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Toolbar.Config 
        { 
			/*  Implicit DesktopTaskBar.Config Conversion to DesktopTaskBar.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DesktopTaskBar.Builder(DesktopTaskBar.Config config)
			{
				return new DesktopTaskBar.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ToolbarCollection quickStart = null;

			/// <summary>
			/// 
			/// </summary>
			public ToolbarCollection QuickStart
			{
				get
				{
					if (this.quickStart == null)
					{
						this.quickStart = new ToolbarCollection();
					}
			
					return this.quickStart;
				}
			}
			        
			private ToolbarCollection tray = null;

			/// <summary>
			/// 
			/// </summary>
			public ToolbarCollection Tray
			{
				get
				{
					if (this.tray == null)
					{
						this.tray = new ToolbarCollection();
					}
			
					return this.tray;
				}
			}
			
			private bool hideQuickStart = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideQuickStart 
			{ 
				get
				{
					return this.hideQuickStart;
				}
				set
				{
					this.hideQuickStart = value;
				}
			}

			private bool hideTray = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideTray 
			{ 
				get
				{
					return this.hideTray;
				}
				set
				{
					this.hideTray = value;
				}
			}

			private int quickStartWidth = 60;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(60)]
			public virtual int QuickStartWidth 
			{ 
				get
				{
					return this.quickStartWidth;
				}
				set
				{
					this.quickStartWidth = value;
				}
			}

			private int trayWidth = 80;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(80)]
			public virtual int TrayWidth 
			{ 
				get
				{
					return this.trayWidth;
				}
				set
				{
					this.trayWidth = value;
				}
			}
        
			private TrayClock trayClock = null;

			/// <summary>
			/// 
			/// </summary>
			public TrayClock TrayClock
			{
				get
				{
					if (this.trayClock == null)
					{
						this.trayClock = new TrayClock();
					}
			
					return this.trayClock;
				}
			}
			
        }
    }
}