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
    public partial class DesktopTaskBar
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Toolbar.Builder<DesktopTaskBar, DesktopTaskBar.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DesktopTaskBar()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopTaskBar component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopTaskBar.Config config) : base(new DesktopTaskBar(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DesktopTaskBar component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopTaskBar.Builder</returns>
            public virtual DesktopTaskBar.Builder QuickStart(Action<ToolbarCollection> action)
            {
                action(this.ToComponent().QuickStart);
                return this as DesktopTaskBar.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopTaskBar.Builder</returns>
            public virtual DesktopTaskBar.Builder Tray(Action<ToolbarCollection> action)
            {
                action(this.ToComponent().Tray);
                return this as DesktopTaskBar.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopTaskBar.Builder HideQuickStart(bool hideQuickStart)
            {
                this.ToComponent().HideQuickStart = hideQuickStart;
                return this as DesktopTaskBar.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopTaskBar.Builder HideTray(bool hideTray)
            {
                this.ToComponent().HideTray = hideTray;
                return this as DesktopTaskBar.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopTaskBar.Builder QuickStartWidth(int quickStartWidth)
            {
                this.ToComponent().QuickStartWidth = quickStartWidth;
                return this as DesktopTaskBar.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopTaskBar.Builder TrayWidth(int trayWidth)
            {
                this.ToComponent().TrayWidth = trayWidth;
                return this as DesktopTaskBar.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopTaskBar.Builder</returns>
            public virtual DesktopTaskBar.Builder TrayClock(Action<TrayClock> action)
            {
                action(this.ToComponent().TrayClock);
                return this as DesktopTaskBar.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DesktopTaskBar(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar.Builder DesktopTaskBar()
        {
            return this.DesktopTaskBar(new DesktopTaskBar());
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar.Builder DesktopTaskBar(DesktopTaskBar component)
        {
            return new DesktopTaskBar.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopTaskBar.Builder DesktopTaskBar(DesktopTaskBar.Config config)
        {
            return new DesktopTaskBar.Builder(new DesktopTaskBar(config));
        }
    }
}