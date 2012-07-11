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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<RowNumbererColumn, RowNumbererColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowNumbererColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowNumbererColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowNumbererColumn.Config config) : base(new RowNumbererColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowNumbererColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// RowSpan attribute for the checkbox table cell
			/// </summary>
            public virtual RowNumbererColumn.Builder RowSpan(int rowSpan)
            {
                this.ToComponent().RowSpan = rowSpan;
                return this as RowNumbererColumn.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowNumbererColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder RowNumbererColumn()
        {
            return this.RowNumbererColumn(new RowNumbererColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder RowNumbererColumn(RowNumbererColumn component)
        {
            return new RowNumbererColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder RowNumbererColumn(RowNumbererColumn.Config config)
        {
            return new RowNumbererColumn.Builder(new RowNumbererColumn(config));
        }
    }
}