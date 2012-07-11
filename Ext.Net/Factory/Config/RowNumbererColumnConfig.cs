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
    public partial class RowNumbererColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RowNumbererColumn.Config Conversion to RowNumbererColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RowNumbererColumn(RowNumbererColumn.Config config)
        {
            return new RowNumbererColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit RowNumbererColumn.Config Conversion to RowNumbererColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RowNumbererColumn.Builder(RowNumbererColumn.Config config)
			{
				return new RowNumbererColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int rowSpan = 1;

			/// <summary>
			/// RowSpan attribute for the checkbox table cell
			/// </summary>
			[DefaultValue(1)]
			public override int RowSpan 
			{ 
				get
				{
					return this.rowSpan;
				}
				set
				{
					this.rowSpan = value;
				}
			}

        }
    }
}