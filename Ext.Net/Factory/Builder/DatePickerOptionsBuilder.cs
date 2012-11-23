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
    public partial class DatePickerOptions
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDatePickerOptions, TBuilder> : DatePicker.Builder<TDatePickerOptions, TBuilder>
            where TDatePickerOptions : DatePickerOptions
            where TBuilder : Builder<TDatePickerOptions, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDatePickerOptions component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DatePickerOptions.Builder<DatePickerOptions, DatePickerOptions.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DatePickerOptions()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DatePickerOptions component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DatePickerOptions.Config config) : base(new DatePickerOptions(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DatePickerOptions component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DatePickerOptions.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DatePickerOptions(this);
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
        public DatePickerOptions.Builder DatePickerOptions()
        {
#if MVC
			return this.DatePickerOptions(new DatePickerOptions { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DatePickerOptions(new DatePickerOptions());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DatePickerOptions.Builder DatePickerOptions(DatePickerOptions component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DatePickerOptions.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DatePickerOptions.Builder DatePickerOptions(DatePickerOptions.Config config)
        {
#if MVC
			return new DatePickerOptions.Builder(new DatePickerOptions(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DatePickerOptions.Builder(new DatePickerOptions(config));
#endif			
        }
    }
}