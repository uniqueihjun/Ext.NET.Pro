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
    public partial class NumericFilter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public NumericFilter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit NumericFilter.Config Conversion to NumericFilter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NumericFilter(NumericFilter.Config config)
        {
            return new NumericFilter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridFilter.Config 
        { 
			/*  Implicit NumericFilter.Config Conversion to NumericFilter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator NumericFilter.Builder(NumericFilter.Config config)
			{
				return new NumericFilter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string emptyText = "Enter Number...";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("Enter Number...")]
			public virtual string EmptyText 
			{ 
				get
				{
					return this.emptyText;
				}
				set
				{
					this.emptyText = value;
				}
			}

			private float? greaterThanValue = null;

			/// <summary>
			/// Predefined filter value
			/// </summary>
			[DefaultValue(null)]
			public virtual float? GreaterThanValue 
			{ 
				get
				{
					return this.greaterThanValue;
				}
				set
				{
					this.greaterThanValue = value;
				}
			}

			private float? lessThanValue = null;

			/// <summary>
			/// Predefined filter value
			/// </summary>
			[DefaultValue(null)]
			public virtual float? LessThanValue 
			{ 
				get
				{
					return this.lessThanValue;
				}
				set
				{
					this.lessThanValue = value;
				}
			}

			private float? equalValue = null;

			/// <summary>
			/// Predefined filter value
			/// </summary>
			[DefaultValue(null)]
			public virtual float? EqualValue 
			{ 
				get
				{
					return this.equalValue;
				}
				set
				{
					this.equalValue = value;
				}
			}

        }
    }
}