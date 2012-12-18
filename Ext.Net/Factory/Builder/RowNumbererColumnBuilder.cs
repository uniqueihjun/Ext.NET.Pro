/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
        new public abstract partial class Builder<TRowNumbererColumn, TBuilder> : ColumnBase.Builder<TRowNumbererColumn, TBuilder>
            where TRowNumbererColumn : RowNumbererColumn
            where TBuilder : Builder<TRowNumbererColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRowNumbererColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// RowSpan attribute for the checkbox table cell
			/// </summary>
            public virtual TBuilder RowSpan(int rowSpan)
            {
                this.ToComponent().RowSpan = rowSpan;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RowNumbererColumn.Builder<RowNumbererColumn, RowNumbererColumn.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowNumbererColumn(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.RowNumbererColumn(new RowNumbererColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RowNumbererColumn(new RowNumbererColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder RowNumbererColumn(RowNumbererColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RowNumbererColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowNumbererColumn.Builder RowNumbererColumn(RowNumbererColumn.Config config)
        {
#if MVC
			return new RowNumbererColumn.Builder(new RowNumbererColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RowNumbererColumn.Builder(new RowNumbererColumn(config));
#endif			
        }
    }
}