/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class ChartTip
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolTipBase.Builder<ChartTip, ChartTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ChartTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartTip.Config config) : base(new ChartTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ChartTip component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ChartTip.Builder</returns>
            public virtual ChartTip.Builder Renderer(Action<JFunction> action)
            {
                action(this.ToComponent().Renderer);
                return this as ChartTip.Builder;
            }
			 
 			/// <summary>
			/// If true, then the tooltip will be automatically constrained to stay within the browser viewport. Defaults to: false
			/// </summary>
            public virtual ChartTip.Builder ConstrainPosition(bool constrainPosition)
            {
                this.ToComponent().ConstrainPosition = constrainPosition;
                return this as ChartTip.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ChartTip.Builder</returns>
            public virtual ChartTip.Builder Listeners(Action<PanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as ChartTip.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ChartTip.Builder</returns>
            public virtual ChartTip.Builder DirectEvents(Action<PanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as ChartTip.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChartTip(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ChartTip()
        {
            return this.ChartTip(new ChartTip());
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ChartTip(ChartTip component)
        {
            return new ChartTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ChartTip(ChartTip.Config config)
        {
            return new ChartTip.Builder(new ChartTip(config));
        }
    }
}