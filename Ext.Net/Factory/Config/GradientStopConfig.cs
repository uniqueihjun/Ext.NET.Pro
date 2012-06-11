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
    public partial class GradientStop
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GradientStop(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GradientStop.Config Conversion to GradientStop
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GradientStop(GradientStop.Config config)
        {
            return new GradientStop(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit GradientStop.Config Conversion to GradientStop.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GradientStop.Builder(GradientStop.Config config)
			{
				return new GradientStop.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int offset = -1;

			/// <summary>
			/// (from 0 to 100)
			/// </summary>
			[DefaultValue(-1)]
			public virtual int Offset 
			{ 
				get
				{
					return this.offset;
				}
				set
				{
					this.offset = value;
				}
			}

			private string color = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Color 
			{ 
				get
				{
					return this.color;
				}
				set
				{
					this.color = value;
				}
			}

			private double opacity = 1d;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(1d)]
			public virtual double Opacity 
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

        }
    }
}