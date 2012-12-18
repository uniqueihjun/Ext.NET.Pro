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
    public partial class TimeAxis
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTimeAxis, TBuilder> : NumericAxis.Builder<TTimeAxis, TBuilder>
            where TTimeAxis : TimeAxis
            where TBuilder : Builder<TTimeAxis, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTimeAxis component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RoundToDecimal(bool roundToDecimal)
            {
                this.ToComponent().RoundToDecimal = roundToDecimal;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// If true, the values of the chart will be rendered only if they belong between the fromDate and toDate. If false, the time axis will adapt to the new values by adding/removing steps. Defaults to: false
			/// </summary>
            public virtual TBuilder Constrain(bool constrain)
            {
                this.ToComponent().Constrain = constrain;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Indicates the format the date will be rendered on. For example: 'MMM dd' will render the dates as 'Jan 30', etc.
			/// </summary>
            public virtual TBuilder DateFormat(string dateFormat)
            {
                this.ToComponent().DateFormat = dateFormat;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The starting date for the time axis.
			/// </summary>
            public virtual TBuilder FromDate(DateTime fromDate)
            {
                this.ToComponent().FromDate = fromDate;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The ending date for the time axis.
			/// </summary>
            public virtual TBuilder ToDate(DateTime toDate)
            {
                this.ToComponent().ToDate = toDate;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The number of units for the step
			/// </summary>
            public virtual TBuilder Step(int step)
            {
                this.ToComponent().Step = step;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The unit of the step (day, month, year, etc).
			/// </summary>
            public virtual TBuilder StepUnit(DateUnit stepUnit)
            {
                this.ToComponent().StepUnit = stepUnit;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TimeAxis.Builder<TimeAxis, TimeAxis.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TimeAxis()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TimeAxis component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TimeAxis.Config config) : base(new TimeAxis(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TimeAxis component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeAxis.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TimeAxis(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TimeAxis.Builder TimeAxis()
        {
#if MVC
			return this.TimeAxis(new TimeAxis { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TimeAxis(new TimeAxis());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeAxis.Builder TimeAxis(TimeAxis component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TimeAxis.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeAxis.Builder TimeAxis(TimeAxis.Config config)
        {
#if MVC
			return new TimeAxis.Builder(new TimeAxis(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TimeAxis.Builder(new TimeAxis(config));
#endif			
        }
    }
}