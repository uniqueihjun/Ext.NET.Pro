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
    public partial class TableGrid
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TableGrid(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TableGrid.Config Conversion to TableGrid
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TableGrid(TableGrid.Config config)
        {
            return new TableGrid(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridPanel.Config 
        { 
			/*  Implicit TableGrid.Config Conversion to TableGrid.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TableGrid.Builder(TableGrid.Config config)
			{
				return new TableGrid.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string table = "";

			/// <summary>
			/// The table element from which this grid will be created.
			/// </summary>
			[DefaultValue("")]
			public virtual string Table 
			{ 
				get
				{
					return this.table;
				}
				set
				{
					this.table = value;
				}
			}
        
			private ColumnModel columnModel = null;

			/// <summary>
			/// 
			/// </summary>
			public ColumnModel ColumnModel
			{
				get
				{
					if (this.columnModel == null)
					{
						this.columnModel = new ColumnModel();
					}
			
					return this.columnModel;
				}
			}
			        
			private ColumnCollection columns = null;

			/// <summary>
			/// The columns to use when rendering the grid (required).
			/// </summary>
			public ColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new ColumnCollection();
					}
			
					return this.columns;
				}
			}
			        
			private RecordFieldCollection fields = null;

			/// <summary>
			/// Either a Collection of RecordField definition objects
			/// </summary>
			public RecordFieldCollection Fields
			{
				get
				{
					if (this.fields == null)
					{
						this.fields = new RecordFieldCollection();
					}
			
					return this.fields;
				}
			}
			
			private bool autoHeight = true;

			/// <summary>
			/// True to use height:'auto', false to use fixed height (defaults to false).
			/// </summary>
			[DefaultValue(true)]
			public override bool AutoHeight 
			{ 
				get
				{
					return this.autoHeight;
				}
				set
				{
					this.autoHeight = value;
				}
			}

        }
    }
}