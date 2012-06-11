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
    public partial class Gradient
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Gradient(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Gradient.Config Conversion to Gradient
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Gradient(Gradient.Config config)
        {
            return new Gradient(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit Gradient.Config Conversion to Gradient.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Gradient.Builder(Gradient.Config config)
			{
				return new Gradient.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string gradientID = "";

			/// <summary>
			/// The unique name of the gradient.
			/// </summary>
			[DefaultValue("")]
			public virtual string GradientID 
			{ 
				get
				{
					return this.gradientID;
				}
				set
				{
					this.gradientID = value;
				}
			}

			private int angle = 0;

			/// <summary>
			/// The angle of the gradient in degrees.
			/// </summary>
			[DefaultValue(0)]
			public virtual int Angle 
			{ 
				get
				{
					return this.angle;
				}
				set
				{
					this.angle = value;
				}
			}
        
			private GradientStops stops = null;

			/// <summary>
			/// An object with numbers as keys (from 0 to 100) and style objects as values
			/// </summary>
			public GradientStops Stops
			{
				get
				{
					if (this.stops == null)
					{
						this.stops = new GradientStops();
					}
			
					return this.stops;
				}
			}
			
        }
    }
}