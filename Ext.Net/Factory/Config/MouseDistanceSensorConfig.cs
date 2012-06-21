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
    public partial class MouseDistanceSensor
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MouseDistanceSensor(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MouseDistanceSensor.Config Conversion to MouseDistanceSensor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MouseDistanceSensor(MouseDistanceSensor.Config config)
        {
            return new MouseDistanceSensor(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit MouseDistanceSensor.Config Conversion to MouseDistanceSensor.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MouseDistanceSensor.Builder(MouseDistanceSensor.Config config)
			{
				return new MouseDistanceSensor.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int threshold = 100;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(100)]
			public virtual int Threshold 
			{ 
				get
				{
					return this.threshold;
				}
				set
				{
					this.threshold = value;
				}
			}

			private bool opacity = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Opacity 
			{ 
				get
				{
					return this.opacity;
				}
				set
				{
					this.opacity = value;
				}
			}

			private decimal minOpacity = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual decimal MinOpacity 
			{ 
				get
				{
					return this.minOpacity;
				}
				set
				{
					this.minOpacity = value;
				}
			}

			private decimal maxOpacity = 1;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1)]
			public virtual decimal MaxOpacity 
			{ 
				get
				{
					return this.maxOpacity;
				}
				set
				{
					this.maxOpacity = value;
				}
			}

			private string sensorElement = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string SensorElement 
			{ 
				get
				{
					return this.sensorElement;
				}
				set
				{
					this.sensorElement = value;
				}
			}

			private string constrainElement = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ConstrainElement 
			{ 
				get
				{
					return this.constrainElement;
				}
				set
				{
					this.constrainElement = value;
				}
			}

        }
    }
}