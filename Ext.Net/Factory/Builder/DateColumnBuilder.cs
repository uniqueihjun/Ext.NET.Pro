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
    public partial class DateColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDateColumn, TBuilder> : CellCommandColumn.Builder<TDateColumn, TBuilder>
            where TDateColumn : DateColumn
            where TBuilder : Builder<TDateColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDateColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A formatting string as used by Date.format to format a Date for this Column. This defaults to the default date from Ext.Date.defaultFormat which itself my be overridden in a locale file.
			/// </summary>
            public virtual TBuilder Format(string format)
            {
                this.ToComponent().Format = format;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DateColumn.Builder<DateColumn, DateColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DateColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateColumn.Config config) : base(new DateColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DateColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DateColumn(this);
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
        public DateColumn.Builder DateColumn()
        {
#if MVC
			return this.DateColumn(new DateColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DateColumn(new DateColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder DateColumn(DateColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DateColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateColumn.Builder DateColumn(DateColumn.Config config)
        {
#if MVC
			return new DateColumn.Builder(new DateColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DateColumn.Builder(new DateColumn(config));
#endif			
        }
    }
}