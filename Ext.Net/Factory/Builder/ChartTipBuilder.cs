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
    public partial class ChartTip
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TChartTip, TBuilder> : ToolTipBase.Builder<TChartTip, TBuilder>
            where TChartTip : ChartTip
            where TBuilder : Builder<TChartTip, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TChartTip component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Renderer(Action<JFunction> action)
            {
                action(this.ToComponent().Renderer);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// If true, then the tooltip will be automatically constrained to stay within the browser viewport. Defaults to: false
			/// </summary>
            public virtual TBuilder ConstrainPosition(bool constrainPosition)
            {
                this.ToComponent().ConstrainPosition = constrainPosition;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<PanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<PanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ChartTip.Builder<ChartTip, ChartTip.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChartTip(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.ChartTip(new ChartTip { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ChartTip(new ChartTip());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ChartTip(ChartTip component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ChartTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTip.Builder ChartTip(ChartTip.Config config)
        {
#if MVC
			return new ChartTip.Builder(new ChartTip(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ChartTip.Builder(new ChartTip(config));
#endif			
        }
    }
}