/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class ColumnSeries
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TColumnSeries, TBuilder> : BarSeries.Builder<TColumnSeries, TBuilder>
            where TColumnSeries : ColumnSeries
            where TBuilder : Builder<TColumnSeries, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TColumnSeries component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Padding between the left/right axes and the bars. Defaults to: 10
			/// </summary>
            public virtual TBuilder XPadding(int xPadding)
            {
                this.ToComponent().XPadding = xPadding;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Padding between the top/bottom axes and the bars. Defaults to: 0
			/// </summary>
            public virtual TBuilder YPadding(int yPadding)
            {
                this.ToComponent().YPadding = yPadding;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnSeries.Builder<ColumnSeries, ColumnSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ColumnSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ColumnSeries.Config config) : base(new ColumnSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ColumnSeries component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ColumnSeries(this);
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
        public ColumnSeries.Builder ColumnSeries()
        {
#if MVC
			return this.ColumnSeries(new ColumnSeries { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ColumnSeries(new ColumnSeries());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnSeries.Builder ColumnSeries(ColumnSeries component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ColumnSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ColumnSeries.Builder ColumnSeries(ColumnSeries.Config config)
        {
#if MVC
			return new ColumnSeries.Builder(new ColumnSeries(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ColumnSeries.Builder(new ColumnSeries(config));
#endif			
        }
    }
}