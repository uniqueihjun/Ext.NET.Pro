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
    public partial class Tool
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComponentBase.Builder<Tool, Tool.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Tool()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Tool component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Tool.Config config) : base(new Tool(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Tool component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Specify as false to allow click event to propagate. Default to true.
			/// </summary>
            public virtual Tool.Builder StopEvent(bool stopEvent)
            {
                this.ToComponent().StopEvent = stopEvent;
                return this as Tool.Builder;
            }
             
 			/// <summary>
			/// A tip string.
			/// </summary>
            public virtual Tool.Builder ToolTip(string toolTip)
            {
                this.ToComponent().ToolTip = toolTip;
                return this as Tool.Builder;
            }
             
 			/// <summary>
			/// A tip string.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Tool.Builder</returns>
            public virtual Tool.Builder TooltipConfig(Action<QTipCfg> action)
            {
                action(this.ToComponent().TooltipConfig);
                return this as Tool.Builder;
            }
			 
 			/// <summary>
			/// The type of tooltip to use. Either 'qtip' (default) for QuickTips or 'title' for title attribute. Defaults to: \"qtip\"
			/// </summary>
            public virtual Tool.Builder ToolTipType(ToolTipType toolTipType)
            {
                this.ToComponent().ToolTipType = toolTipType;
                return this as Tool.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Tool.Builder</returns>
            public virtual Tool.Builder Listeners(Action<ToolListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Tool.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Tool.Builder</returns>
            public virtual Tool.Builder DirectEvents(Action<ToolDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Tool.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Tool(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Tool.Builder Tool()
        {
            return this.Tool(new Tool());
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool.Builder Tool(Tool component)
        {
            return new Tool.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool.Builder Tool(Tool.Config config)
        {
            return new Tool.Builder(new Tool(config));
        }
    }
}