/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class TableLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TableLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TableLayout.Config Conversion to TableLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TableLayout(TableLayout.Config config)
        {
            return new TableLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit TableLayout.Config Conversion to TableLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TableLayout.Builder(TableLayout.Config config)
			{
				return new TableLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private DomObject tableAttrs = null;

			/// <summary>
			/// An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.
			/// </summary>
			public DomObject TableAttrs
			{
				get
				{
					if (this.tableAttrs == null)
					{
						this.tableAttrs = new DomObject();
					}
			
					return this.tableAttrs;
				}
			}
			
			private int columns = 0;

			/// <summary>
			/// The total number of columns to create in the table for this layout. If not specified, all panels added to this layout will be rendered into a single row using a column per panel.
			/// </summary>
			[DefaultValue(0)]
			public virtual int Columns 
			{ 
				get
				{
					return this.columns;
				}
				set
				{
					this.columns = value;
				}
			}
        
			private CellCollection cells = null;

			/// <summary>
			/// Cells collection
			/// </summary>
			public CellCollection Cells
			{
				get
				{
					if (this.cells == null)
					{
						this.cells = new CellCollection();
					}
			
					return this.cells;
				}
			}
			
        }
    }
}