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
    public partial class ColumnSeries
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ColumnSeries(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ColumnSeries.Config Conversion to ColumnSeries
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColumnSeries(ColumnSeries.Config config)
        {
            return new ColumnSeries(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BarSeries.Config 
        { 
			/*  Implicit ColumnSeries.Config Conversion to ColumnSeries.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ColumnSeries.Builder(ColumnSeries.Config config)
			{
				return new ColumnSeries.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int xPadding = 10;

			/// <summary>
			/// Padding between the left/right axes and the bars. Defaults to: 10
			/// </summary>
			[DefaultValue(10)]
			public override int XPadding 
			{ 
				get
				{
					return this.xPadding;
				}
				set
				{
					this.xPadding = value;
				}
			}

			private int yPadding = 0;

			/// <summary>
			/// Padding between the top/bottom axes and the bars. Defaults to: 0
			/// </summary>
			[DefaultValue(0)]
			public override int YPadding 
			{ 
				get
				{
					return this.yPadding;
				}
				set
				{
					this.yPadding = value;
				}
			}

        }
    }
}