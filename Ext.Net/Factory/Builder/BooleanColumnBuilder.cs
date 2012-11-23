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
    public partial class BooleanColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TBooleanColumn, TBuilder> : CellCommandColumn.Builder<TBooleanColumn, TBuilder>
            where TBooleanColumn : BooleanColumn
            where TBuilder : Builder<TBooleanColumn, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TBooleanColumn component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
			/// </summary>
            public virtual TBuilder FalseText(string falseText)
            {
                this.ToComponent().FalseText = falseText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The string returned by the renderer when the column value is not falsey (defaults to 'true').
			/// </summary>
            public virtual TBuilder TrueText(string trueText)
            {
                this.ToComponent().TrueText = trueText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The string returned by the renderer when the column value is undefined (defaults to ' ').
			/// </summary>
            public virtual TBuilder UndefinedText(string undefinedText)
            {
                this.ToComponent().UndefinedText = undefinedText;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : BooleanColumn.Builder<BooleanColumn, BooleanColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new BooleanColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BooleanColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(BooleanColumn.Config config) : base(new BooleanColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(BooleanColumn component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.BooleanColumn(this);
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
        public BooleanColumn.Builder BooleanColumn()
        {
#if MVC
			return this.BooleanColumn(new BooleanColumn { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.BooleanColumn(new BooleanColumn());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder BooleanColumn(BooleanColumn component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new BooleanColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public BooleanColumn.Builder BooleanColumn(BooleanColumn.Config config)
        {
#if MVC
			return new BooleanColumn.Builder(new BooleanColumn(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new BooleanColumn.Builder(new BooleanColumn(config));
#endif			
        }
    }
}