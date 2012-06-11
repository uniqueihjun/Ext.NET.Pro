/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class GaugeSeries
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GaugeSeries(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GaugeSeries.Config Conversion to GaugeSeries
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GaugeSeries(GaugeSeries.Config config)
        {
            return new GaugeSeries(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractSeries.Config 
        { 
			/*  Implicit GaugeSeries.Config Conversion to GaugeSeries.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GaugeSeries.Builder(GaugeSeries.Config config)
			{
				return new GaugeSeries.Builder(config);
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

			private int donut = 0;

			/// <summary>
			/// Use the entire disk or just a fraction of it for the gauge.
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

			private bool needle = false;

			/// <summary>
			/// Use the Gauge Series as an area series or add a needle to it. Default's false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Needle 
			{ 
				get
				{
					return this.needle;
				}
				set
				{
					this.needle = value;
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

        }
    }
}