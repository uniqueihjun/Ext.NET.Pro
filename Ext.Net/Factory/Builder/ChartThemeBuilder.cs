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
    public partial class ChartTheme
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<ChartTheme, ChartTheme.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ChartTheme()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartTheme component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ChartTheme.Config config) : base(new ChartTheme(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ChartTheme component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder ThemeName(string themeName)
            {
                this.ToComponent().ThemeName = themeName;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder Background(bool background)
            {
                this.ToComponent().Background = background;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder UseGradients(bool useGradients)
            {
                this.ToComponent().UseGradients = useGradients;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder BaseColor(string baseColor)
            {
                this.ToComponent().BaseColor = baseColor;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder Colors(string[] colors)
            {
                this.ToComponent().Colors = colors;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder Axis(SpriteAttributes axis)
            {
                this.ToComponent().Axis = axis;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisLabelTop(SpriteAttributes axisLabelTop)
            {
                this.ToComponent().AxisLabelTop = axisLabelTop;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisLabelRight(SpriteAttributes axisLabelRight)
            {
                this.ToComponent().AxisLabelRight = axisLabelRight;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisLabelBottom(SpriteAttributes axisLabelBottom)
            {
                this.ToComponent().AxisLabelBottom = axisLabelBottom;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisLabelLeft(SpriteAttributes axisLabelLeft)
            {
                this.ToComponent().AxisLabelLeft = axisLabelLeft;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisTitleTop(SpriteAttributes axisTitleTop)
            {
                this.ToComponent().AxisTitleTop = axisTitleTop;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisTitleRight(SpriteAttributes axisTitleRight)
            {
                this.ToComponent().AxisTitleRight = axisTitleRight;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisTitleBottom(SpriteAttributes axisTitleBottom)
            {
                this.ToComponent().AxisTitleBottom = axisTitleBottom;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisTitleLeft(SpriteAttributes axisTitleLeft)
            {
                this.ToComponent().AxisTitleLeft = axisTitleLeft;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder Series(SpriteAttributes series)
            {
                this.ToComponent().Series = series;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder SeriesLabel(SpriteAttributes seriesLabel)
            {
                this.ToComponent().SeriesLabel = seriesLabel;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder Marker(SpriteAttributes marker)
            {
                this.ToComponent().Marker = marker;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisLabel(SpriteAttributes axisLabel)
            {
                this.ToComponent().AxisLabel = axisLabel;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ChartTheme.Builder AxisTitle(SpriteAttributes axisTitle)
            {
                this.ToComponent().AxisTitle = axisTitle;
                return this as ChartTheme.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ChartTheme.Builder</returns>
            public virtual ChartTheme.Builder SeriesThemes(Action<SpriteAttributesCollection> action)
            {
                action(this.ToComponent().SeriesThemes);
                return this as ChartTheme.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ChartTheme.Builder</returns>
            public virtual ChartTheme.Builder MarkerThemes(Action<SpriteAttributesCollection> action)
            {
                action(this.ToComponent().MarkerThemes);
                return this as ChartTheme.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTheme.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ChartTheme(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ChartTheme.Builder ChartTheme()
        {
            return this.ChartTheme(new ChartTheme());
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTheme.Builder ChartTheme(ChartTheme component)
        {
            return new ChartTheme.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartTheme.Builder ChartTheme(ChartTheme.Config config)
        {
            return new ChartTheme.Builder(new ChartTheme(config));
        }
    }
}