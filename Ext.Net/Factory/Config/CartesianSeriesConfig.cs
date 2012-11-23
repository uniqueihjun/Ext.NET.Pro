/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public abstract partial class CartesianSeries
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractSeries.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Position axis = Position.Left;

			/// <summary>
			/// The position of the axis to bind the values to. Possible values are 'left', 'bottom', 'top' and 'right'. You must explicitly set this value to bind the values of the line series to the ones in the axis, otherwise a relative scale will be used. Defaults to: \"left\"
			/// </summary>
			[DefaultValue(Position.Left)]
			public virtual Position Axis 
			{ 
				get
				{
					return this.axis;
				}
				set
				{
					this.axis = value;
				}
			}

			private Position[] axes = null;

			/// <summary>
			/// The array of positions of the axes to bind the values to.
			/// </summary>
			[DefaultValue(null)]
			public virtual Position[] Axes 
			{ 
				get
				{
					return this.axes;
				}
				set
				{
					this.axes = value;
				}
			}

        }
    }
}