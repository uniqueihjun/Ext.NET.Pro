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
    public partial class NumberColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TNumberColumn, TBuilder> : CellCommandColumn.Builder<TNumberColumn, TBuilder>
            where TNumberColumn : NumberColumn
            where TBuilder : Builder<TNumberColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TNumberColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A formatting string as used by Ext.util.Format.number to format a numeric value for this Column (defaults to '0,000.00').
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
        public partial class Builder : NumberColumn.Builder<NumberColumn, NumberColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new NumberColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumberColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumberColumn.Config config) : base(new NumberColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(NumberColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public NumberColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.NumberColumn(this);
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
        public NumberColumn.Builder NumberColumn()
        {
#if MVC
			return this.NumberColumn(new NumberColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.NumberColumn(new NumberColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public NumberColumn.Builder NumberColumn(NumberColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new NumberColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public NumberColumn.Builder NumberColumn(NumberColumn.Config config)
        {
#if MVC
			return new NumberColumn.Builder(new NumberColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new NumberColumn.Builder(new NumberColumn(config));
#endif			
        }
    }
}