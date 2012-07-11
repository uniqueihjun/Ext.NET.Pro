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
    public partial class RadarSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractSeries.Builder<RadarSeries, RadarSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadarSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadarSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadarSeries.Config config) : base(new RadarSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadarSeries component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadarSeries.Builder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as RadarSeries.Builder;
            }
             
 			/// <summary>
			/// Whether markers should be displayed at the data points. If true, then the markerConfig config item will determine the markers' styling.
			/// </summary>
            public virtual RadarSeries.Builder ShowMarkers(bool showMarkers)
            {
                this.ToComponent().ShowMarkers = showMarkers;
                return this as RadarSeries.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual RadarSeries.Builder MarkerConfig(SpriteAttributes markerConfig)
            {
                this.ToComponent().MarkerConfig = markerConfig;
                return this as RadarSeries.Builder;
            }
             
 			/// <summary>
			/// Whether to add the chart elements as legend items. Default's false.
			/// </summary>
            public virtual RadarSeries.Builder ShowInLegend(bool showInLegend)
            {
                this.ToComponent().ShowInLegend = showInLegend;
                return this as RadarSeries.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadarSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadarSeries(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RadarSeries.Builder RadarSeries()
        {
            return this.RadarSeries(new RadarSeries());
        }

        /// <summary>
        /// 
        /// </summary>
        public RadarSeries.Builder RadarSeries(RadarSeries component)
        {
            return new RadarSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadarSeries.Builder RadarSeries(RadarSeries.Config config)
        {
            return new RadarSeries.Builder(new RadarSeries(config));
        }
    }
}