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
    public partial class Cell
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LayoutItem.Builder<Cell, Cell.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Cell()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Cell component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Cell.Config config) : base(new Cell(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Cell component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual Cell.Builder RowSpan(int rowSpan)
            {
                this.ToComponent().RowSpan = rowSpan;
                return this as Cell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Cell.Builder ColSpan(int colSpan)
            {
                this.ToComponent().ColSpan = colSpan;
                return this as Cell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Cell.Builder CellCls(string cellCls)
            {
                this.ToComponent().CellCls = cellCls;
                return this as Cell.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Cell.Builder CellId(string cellId)
            {
                this.ToComponent().CellId = cellId;
                return this as Cell.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Cell.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Cell(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Cell.Builder Cell()
        {
            return this.Cell(new Cell());
        }

        /// <summary>
        /// 
        /// </summary>
        public Cell.Builder Cell(Cell component)
        {
            return new Cell.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Cell.Builder Cell(Cell.Config config)
        {
            return new Cell.Builder(new Cell(config));
        }
    }
}