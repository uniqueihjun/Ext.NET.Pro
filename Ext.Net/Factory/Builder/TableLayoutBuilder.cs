/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class TableLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ContainerLayout.Builder<TableLayout, TableLayout.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TableLayout()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TableLayout component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TableLayout.Config config) : base(new TableLayout(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TableLayout component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.
			// /// </summary>
            // public virtual TBuilder TableAttrs(DomObject tableAttrs)
            // {
            //    this.ToComponent().TableAttrs = tableAttrs;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// The total number of columns to create in the table for this layout. If not specified, all panels added to this layout will be rendered into a single row using a column per panel.
			/// </summary>
            public virtual TableLayout.Builder Columns(int columns)
            {
                this.ToComponent().Columns = columns;
                return this as TableLayout.Builder;
            }
             
 			// /// <summary>
			// /// Cells collection
			// /// </summary>
            // public virtual TBuilder Cells(CellCollection cells)
            // {
            //    this.ToComponent().Cells = cells;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TableLayout.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TableLayout(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TableLayout.Builder TableLayout()
        {
            return this.TableLayout(new TableLayout());
        }

        /// <summary>
        /// 
        /// </summary>
        public TableLayout.Builder TableLayout(TableLayout component)
        {
            return new TableLayout.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TableLayout.Builder TableLayout(TableLayout.Config config)
        {
            return new TableLayout.Builder(new TableLayout(config));
        }
    }
}