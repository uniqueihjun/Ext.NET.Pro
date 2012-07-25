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
    public partial class GaugeAxis
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractAxis.Builder<GaugeAxis, GaugeAxis.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GaugeAxis()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GaugeAxis component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GaugeAxis.Config config) : base(new GaugeAxis(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GaugeAxis component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The offset positioning of the tick marks and labels in pixels. Defaults to: 10
			/// </summary>
            public virtual GaugeAxis.Builder Margin(int margin)
            {
                this.ToComponent().Margin = margin;
                return this as GaugeAxis.Builder;
            }
             
 			/// <summary>
			/// The maximum value of the interval to be displayed in the axis (REQUIRED).
			/// </summary>
            public virtual GaugeAxis.Builder Maximum(int? maximum)
            {
                this.ToComponent().Maximum = maximum;
                return this as GaugeAxis.Builder;
            }
             
 			/// <summary>
			/// The minimum value of the interval to be displayed in the axis (REQUIRED).
			/// </summary>
            public virtual GaugeAxis.Builder Minimum(int? minimum)
            {
                this.ToComponent().Minimum = minimum;
                return this as GaugeAxis.Builder;
            }
             
 			/// <summary>
			/// The number of steps and tick marks to add to the interval. (REQUIRED).
			/// </summary>
            public virtual GaugeAxis.Builder Steps(int? steps)
            {
                this.ToComponent().Steps = steps;
                return this as GaugeAxis.Builder;
            }
             
 			/// <summary>
			/// The title for the Axis.
			/// </summary>
            public virtual GaugeAxis.Builder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as GaugeAxis.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public GaugeAxis.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GaugeAxis(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GaugeAxis.Builder GaugeAxis()
        {
            return this.GaugeAxis(new GaugeAxis());
        }

        /// <summary>
        /// 
        /// </summary>
        public GaugeAxis.Builder GaugeAxis(GaugeAxis component)
        {
            return new GaugeAxis.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GaugeAxis.Builder GaugeAxis(GaugeAxis.Config config)
        {
            return new GaugeAxis.Builder(new GaugeAxis(config));
        }
    }
}