/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TimeAxis(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TimeAxis.Config Conversion to TimeAxis
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimeAxis(TimeAxis.Config config)
        {
            return new TimeAxis(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : NumericAxis.Config 
        { 
			/*  Implicit TimeAxis.Config Conversion to TimeAxis.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TimeAxis.Builder(TimeAxis.Config config)
			{
				return new TimeAxis.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool roundToDecimal = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public override bool RoundToDecimal 
			{ 
				get
				{
					return this.roundToDecimal;
				}
				set
				{
					this.roundToDecimal = value;
				}
			}

			private bool constrain = false;

			/// <summary>
			/// If true, the values of the chart will be rendered only if they belong between the fromDate and toDate. If false, the time axis will adapt to the new values by adding/removing steps. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public override bool Constrain 
			{ 
				get
				{
					return this.constrain;
				}
				set
				{
					this.constrain = value;
				}
			}

			private string dateFormat = "";

			/// <summary>
			/// Indicates the format the date will be rendered on. For example: 'MMM dd' will render the dates as 'Jan 30', etc.
			/// </summary>
			[DefaultValue("")]
			public virtual string DateFormat 
			{ 
				get
				{
					return this.dateFormat;
				}
				set
				{
					this.dateFormat = value;
				}
			}

			private DateTime fromDate = new DateTime(0001, 01, 01);

			/// <summary>
			/// The starting date for the time axis.
			/// </summary>
			[DefaultValue(typeof(DateTime), "0001-01-01")]
			public virtual DateTime FromDate 
			{ 
				get
				{
					return this.fromDate;
				}
				set
				{
					this.fromDate = value;
				}
			}

			private DateTime toDate = new DateTime(9999, 12, 31);

			/// <summary>
			/// The ending date for the time axis.
			/// </summary>
			[DefaultValue(typeof(DateTime), "9999-12-31")]
			public virtual DateTime ToDate 
			{ 
				get
				{
					return this.toDate;
				}
				set
				{
					this.toDate = value;
				}
			}

			private int step = 1;

			/// <summary>
			/// The number of units for the step
			/// </summary>
			[DefaultValue(1)]
			public virtual int Step 
			{ 
				get
				{
					return this.step;
				}
				set
				{
					this.step = value;
				}
			}

			private DateUnit stepUnit = DateUnit.Day;

			/// <summary>
			/// The unit of the step (day, month, year, etc).
			/// </summary>
			[DefaultValue(DateUnit.Day)]
			public virtual DateUnit StepUnit 
			{ 
				get
				{
					return this.stepUnit;
				}
				set
				{
					this.stepUnit = value;
				}
			}

        }
    }
}