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
    public partial class LineSeries
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TLineSeries, TBuilder> : CartesianSeries.Builder<TLineSeries, TBuilder>
            where TLineSeries : LineSeries
            where TBuilder : Builder<TLineSeries, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TLineSeries component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// If true, the area below the line will be filled in using the eefill and opacity config properties. Defaults to false.
			/// </summary>
            public virtual TBuilder Fill(bool fill)
            {
                this.ToComponent().Fill = fill;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Whether markers should be displayed at the data points along the line. If true, then the markerConfig config item will determine the markers' styling. Defaults to: true
			/// </summary>
            public virtual TBuilder ShowMarkers(bool showMarkers)
            {
                this.ToComponent().ShowMarkers = showMarkers;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder MarkerConfig(SpriteAttributes markerConfig)
            {
                this.ToComponent().MarkerConfig = markerConfig;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The offset distance from the cursor position to the line series to trigger events (then used for highlighting series, etc). Defaults to: 20
			/// </summary>
            public virtual TBuilder SelectionTolerance(int selectionTolerance)
            {
                this.ToComponent().SelectionTolerance = selectionTolerance;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// If set to a non-zero number, the line will be smoothed/rounded around its points; otherwise straight line segments will be drawn.
			/// </summary>
            public virtual TBuilder Smooth(int smooth)
            {
                this.ToComponent().Smooth = smooth;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : LineSeries.Builder<LineSeries, LineSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LineSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LineSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LineSeries.Config config) : base(new LineSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LineSeries component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LineSeries(this);
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
        public LineSeries.Builder LineSeries()
        {
#if MVC
			return this.LineSeries(new LineSeries { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.LineSeries(new LineSeries());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder LineSeries(LineSeries component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new LineSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder LineSeries(LineSeries.Config config)
        {
#if MVC
			return new LineSeries.Builder(new LineSeries(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new LineSeries.Builder(new LineSeries(config));
#endif			
        }
    }
}