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
    public partial class PieSeries
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public PieSeries(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit PieSeries.Config Conversion to PieSeries
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PieSeries(PieSeries.Config config)
        {
            return new PieSeries(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractSeries.Config 
        { 
			/*  Implicit PieSeries.Config Conversion to PieSeries.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator PieSeries.Builder(PieSeries.Config config)
			{
				return new PieSeries.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string angleField = "";

			/// <summary>
			/// The store record field name to be used for the pie angles. The values bound to this field name must be positive real numbers. REQUIRED
			/// </summary>
			[DefaultValue("")]
			public virtual string AngleField 
			{ 
				get
				{
					return this.angleField;
				}
				set
				{
					this.angleField = value;
				}
			}

			private string[] colorSet = null;

			/// <summary>
			/// An array of color values which will be used, in order, as the gauge slice fill colors.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] ColorSet 
			{ 
				get
				{
					return this.colorSet;
				}
				set
				{
					this.colorSet = value;
				}
			}

			private int donut = 0;

			/// <summary>
			/// Whether to set the pie chart as donut chart. Default's false. Can be set to a particular percentage to set the radius of the donut chart.
			/// </summary>
			[DefaultValue(0)]
			public virtual int Donut 
			{ 
				get
				{
					return this.donut;
				}
				set
				{
					this.donut = value;
				}
			}

			private int highlightDuration = 150;

			/// <summary>
			/// The duration for the pie slice highlight effect. Defaults to: 150
			/// </summary>
			[DefaultValue(150)]
			public virtual int HighlightDuration 
			{ 
				get
				{
					return this.highlightDuration;
				}
				set
				{
					this.highlightDuration = value;
				}
			}

			private int? highlightSegmentMargin = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual int? HighlightSegmentMargin 
			{ 
				get
				{
					return this.highlightSegmentMargin;
				}
				set
				{
					this.highlightSegmentMargin = value;
				}
			}

			private string lengthField = "";

			/// <summary>
			/// The store record field name to be used for the pie slice lengths. The values bound to this field name must be positive real numbers.
			/// </summary>
			[DefaultValue("")]
			public virtual string LengthField 
			{ 
				get
				{
					return this.lengthField;
				}
				set
				{
					this.lengthField = value;
				}
			}

			private bool showInLegend = false;

			/// <summary>
			/// Whether to add the pie chart elements as legend items. Default's false.
			/// </summary>
			[DefaultValue(false)]
			public override bool ShowInLegend 
			{ 
				get
				{
					return this.showInLegend;
				}
				set
				{
					this.showInLegend = value;
				}
			}

			private SpriteAttributes style = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual SpriteAttributes Style 
			{ 
				get
				{
					return this.style;
				}
				set
				{
					this.style = value;
				}
			}

        }
    }
}