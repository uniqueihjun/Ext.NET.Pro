/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class RadialAxis
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RadialAxis.Config Conversion to RadialAxis
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RadialAxis(RadialAxis.Config config)
        {
            return new RadialAxis(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractAxis.Config 
        { 
			/*  Implicit RadialAxis.Config Conversion to RadialAxis.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RadialAxis.Builder(RadialAxis.Config config)
			{
				return new RadialAxis.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int steps = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual int Steps 
			{ 
				get
				{
					return this.steps;
				}
				set
				{
					this.steps = value;
				}
			}

			private int maximum = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual int Maximum 
			{ 
				get
				{
					return this.maximum;
				}
				set
				{
					this.maximum = value;
				}
			}

        }
    }
}