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
    public partial class NumericFilter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TNumericFilter, TBuilder> : GridFilter.Builder<TNumericFilter, TBuilder>
            where TNumericFilter : NumericFilter
            where TBuilder : Builder<TNumericFilter, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TNumericFilter component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder EmptyText(string emptyText)
            {
                this.ToComponent().EmptyText = emptyText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder GreaterThanValue(float? greaterThanValue)
            {
                this.ToComponent().GreaterThanValue = greaterThanValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder LessThanValue(float? lessThanValue)
            {
                this.ToComponent().LessThanValue = lessThanValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder EqualValue(float? equalValue)
            {
                this.ToComponent().EqualValue = equalValue;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : NumericFilter.Builder<NumericFilter, NumericFilter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new NumericFilter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumericFilter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumericFilter.Config config) : base(new NumericFilter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(NumericFilter component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public NumericFilter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.NumericFilter(this);
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
        public NumericFilter.Builder NumericFilter()
        {
#if MVC
			return this.NumericFilter(new NumericFilter { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.NumericFilter(new NumericFilter());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public NumericFilter.Builder NumericFilter(NumericFilter component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new NumericFilter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public NumericFilter.Builder NumericFilter(NumericFilter.Config config)
        {
#if MVC
			return new NumericFilter.Builder(new NumericFilter(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new NumericFilter.Builder(new NumericFilter(config));
#endif			
        }
    }
}