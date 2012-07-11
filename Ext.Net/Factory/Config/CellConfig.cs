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
    public partial class Cell
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Cell(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Cell.Config Conversion to Cell
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Cell(Cell.Config config)
        {
            return new Cell(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LayoutItem.Config 
        { 
			/*  Implicit Cell.Config Conversion to Cell.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Cell.Builder(Cell.Config config)
			{
				return new Cell.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int rowSpan = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual int RowSpan 
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

			private int colSpan = 0;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(0)]
			public virtual int ColSpan 
			{ 
				get
				{
					return this.colSpan;
				}
				set
				{
					this.colSpan = value;
				}
			}

			private string cellCls = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string CellCls 
			{ 
				get
				{
					return this.cellCls;
				}
				set
				{
					this.cellCls = value;
				}
			}

			private string cellId = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string CellId 
			{ 
				get
				{
					return this.cellId;
				}
				set
				{
					this.cellId = value;
				}
			}

        }
    }
}