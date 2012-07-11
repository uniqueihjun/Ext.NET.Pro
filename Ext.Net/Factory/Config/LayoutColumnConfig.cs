/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class LayoutColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public LayoutColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit LayoutColumn.Config Conversion to LayoutColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LayoutColumn(LayoutColumn.Config config)
        {
            return new LayoutColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LayoutItem.Config 
        { 
			/*  Implicit LayoutColumn.Config Conversion to LayoutColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator LayoutColumn.Builder(LayoutColumn.Config config)
			{
				return new LayoutColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private decimal columnWidth = 0;

			/// <summary>
			/// The ColumnWidth property is always evaluated as a percentage, and must be a decimal value greater than 0 and less than or equal to 1.0.
			/// </summary>
			[DefaultValue(0)]
			public virtual decimal ColumnWidth 
			{ 
				get
				{
					return this.columnWidth;
				}
				set
				{
					this.columnWidth = value;
				}
			}

        }
    }
}