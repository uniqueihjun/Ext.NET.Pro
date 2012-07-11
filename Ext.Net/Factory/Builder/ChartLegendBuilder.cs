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
    public partial class ChartLegend
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<ChartLegend, ChartLegend.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ChartLegend()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartLegend component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartLegend.Config config) : base(new ChartLegend(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ChartLegend component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Fill style for the legend box. Defaults to: \"#FFF\"
			/// </summary>
            public virtual ChartLegend.Builder BoxFill(string boxFill)
            {
                this.ToComponent().BoxFill = boxFill;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Style of the stroke for the legend box. Defaults to: \"#000\"
			/// </summary>
            public virtual ChartLegend.Builder BoxStroke(string boxStroke)
            {
                this.ToComponent().BoxStroke = boxStroke;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Width of the stroke for the legend box. Defaults to: 1
			/// </summary>
            public virtual ChartLegend.Builder BoxStrokeWidth(int boxStrokeWidth)
            {
                this.ToComponent().BoxStrokeWidth = boxStrokeWidth;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Sets the z-index for the legend. Defaults to 100.
			/// </summary>
            public virtual ChartLegend.Builder BoxZIndex(int boxZIndex)
            {
                this.ToComponent().BoxZIndex = boxZIndex;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Amount of space between legend items. Defaults to: 10
			/// </summary>
            public virtual ChartLegend.Builder ItemSpacing(int itemSpacing)
            {
                this.ToComponent().ItemSpacing = itemSpacing;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Color to be used for the legend labels, eg '#000'. Defaults to: \"#000\"
			/// </summary>
            public virtual ChartLegend.Builder LabelColor(string labelColor)
            {
                this.ToComponent().LabelColor = labelColor;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Font to be used for the legend labels, eg '12px Helvetica'. Defaults to: \"12px Helvetica, sans-serif\"
			/// </summary>
            public virtual ChartLegend.Builder LabelFont(string labelFont)
            {
                this.ToComponent().LabelFont = labelFont;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Amount of padding between the legend box's border and its items. Defaults to: 5
			/// </summary>
            public virtual ChartLegend.Builder Padding(int padding)
            {
                this.ToComponent().Padding = padding;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// The position of the legend in relation to the chart. One of: \"top\", \"bottom\", \"left\", \"right\", or \"float\". If set to \"float\", then the legend box will be positioned at the point denoted by the x and y parameters. Defaults to: \"bottom\"
			/// </summary>
            public virtual ChartLegend.Builder Position(LegendPosition position)
            {
                this.ToComponent().Position = position;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// If set to true the chart will be refreshed after show/hide series
			/// </summary>
            public virtual ChartLegend.Builder RefreshOnItemToggle(bool refreshOnItemToggle)
            {
                this.ToComponent().RefreshOnItemToggle = refreshOnItemToggle;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// If set to true the legend will be refreshed when the chart is. This is useful to update the legend items if series are added/removed/updated from the chart. Default is true.
			/// </summary>
            public virtual ChartLegend.Builder Update(bool update)
            {
                this.ToComponent().Update = update;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Whether or not the legend should be displayed. Defaults to: true
			/// </summary>
            public virtual ChartLegend.Builder Visible(bool visible)
            {
                this.ToComponent().Visible = visible;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// X-position of the legend box. Used directly if position is set to \"float\", otherwise it will be calculated dynamically. Defaults to: 0
			/// </summary>
            public virtual ChartLegend.Builder X(int x)
            {
                this.ToComponent().X = x;
                return this as ChartLegend.Builder;
            }
             
 			/// <summary>
			/// Y-position of the legend box. Used directly if position is set to \"float\", otherwise it will be calculated dynamically. Defaults to: 0
			/// </summary>
            public virtual ChartLegend.Builder Y(int y)
            {
                this.ToComponent().Y = y;
                return this as ChartLegend.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartLegend.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChartLegend(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ChartLegend.Builder ChartLegend()
        {
            return this.ChartLegend(new ChartLegend());
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartLegend.Builder ChartLegend(ChartLegend component)
        {
            return new ChartLegend.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartLegend.Builder ChartLegend(ChartLegend.Config config)
        {
            return new ChartLegend.Builder(new ChartLegend(config));
        }
    }
}