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
    public partial class LineSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CartesianSeries.Builder<LineSeries, LineSeries.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// If true, the area below the line will be filled in using the eefill and opacity config properties. Defaults to false.
			/// </summary>
            public virtual LineSeries.Builder Fill(bool fill)
            {
                this.ToComponent().Fill = fill;
                return this as LineSeries.Builder;
            }
             
 			/// <summary>
			/// Whether markers should be displayed at the data points along the line. If true, then the markerConfig config item will determine the markers' styling. Defaults to: true
			/// </summary>
            public virtual LineSeries.Builder ShowMarkers(bool showMarkers)
            {
                this.ToComponent().ShowMarkers = showMarkers;
                return this as LineSeries.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual LineSeries.Builder MarkerConfig(SpriteAttributes markerConfig)
            {
                this.ToComponent().MarkerConfig = markerConfig;
                return this as LineSeries.Builder;
            }
             
 			/// <summary>
			/// The offset distance from the cursor position to the line series to trigger events (then used for highlighting series, etc). Defaults to: 20
			/// </summary>
            public virtual LineSeries.Builder SelectionTolerance(int selectionTolerance)
            {
                this.ToComponent().SelectionTolerance = selectionTolerance;
                return this as LineSeries.Builder;
            }
             
 			/// <summary>
			/// If set to a non-zero number, the line will be smoothed/rounded around its points; otherwise straight line segments will be drawn.
			/// </summary>
            public virtual LineSeries.Builder Smooth(int smooth)
            {
                this.ToComponent().Smooth = smooth;
                return this as LineSeries.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual LineSeries.Builder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as LineSeries.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LineSeries(this);
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
            return this.LineSeries(new LineSeries());
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder LineSeries(LineSeries component)
        {
            return new LineSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LineSeries.Builder LineSeries(LineSeries.Config config)
        {
            return new LineSeries.Builder(new LineSeries(config));
        }
    }
}