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
    public partial class SummaryColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SummaryColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SummaryColumn.Config Conversion to SummaryColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SummaryColumn(SummaryColumn.Config config)
        {
            return new SummaryColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Column.Config 
        { 
			/*  Implicit SummaryColumn.Config Conversion to SummaryColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SummaryColumn.Builder(SummaryColumn.Config config)
			{
				return new SummaryColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private SummaryType summaryType = SummaryType.None;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(SummaryType.None)]
			public virtual SummaryType SummaryType 
			{ 
				get
				{
					return this.summaryType;
				}
				set
				{
					this.summaryType = value;
				}
			}

			private string customSummaryType = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string CustomSummaryType 
			{ 
				get
				{
					return this.customSummaryType;
				}
				set
				{
					this.customSummaryType = value;
				}
			}
        
			private JFunction summaryRenderer = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction SummaryRenderer
			{
				get
				{
					if (this.summaryRenderer == null)
					{
						this.summaryRenderer = new JFunction();
					}
			
					return this.summaryRenderer;
				}
			}
			
        }
    }
}