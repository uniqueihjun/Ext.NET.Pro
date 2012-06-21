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
    public abstract partial class CartesianSeries
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TCartesianSeries, TBuilder> : AbstractSeries.Builder<TCartesianSeries, TBuilder>
            where TCartesianSeries : CartesianSeries
            where TBuilder : Builder<TCartesianSeries, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCartesianSeries component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The position of the axis to bind the values to. Possible values are 'left', 'bottom', 'top' and 'right'. You must explicitly set this value to bind the values of the line series to the ones in the axis, otherwise a relative scale will be used. Defaults to: \"left\"
			/// </summary>
            public virtual TBuilder Axis(Position axis)
            {
                this.ToComponent().Axis = axis;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The array of positions of the axes to bind the values to.
			/// </summary>
            public virtual TBuilder Axes(Position[] axes)
            {
                this.ToComponent().Axes = axes;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}