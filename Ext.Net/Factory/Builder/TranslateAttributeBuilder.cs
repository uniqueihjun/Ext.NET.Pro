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
    public partial class TranslateAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTranslateAttribute, TBuilder> : BaseItem.Builder<TTranslateAttribute, TBuilder>
            where TTranslateAttribute : TranslateAttribute
            where TBuilder : Builder<TTranslateAttribute, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTranslateAttribute component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder X(double? x)
            {
                this.ToComponent().X = x;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Y(double? y)
            {
                this.ToComponent().Y = y;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TranslateAttribute.Builder<TranslateAttribute, TranslateAttribute.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TranslateAttribute()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TranslateAttribute component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TranslateAttribute.Config config) : base(new TranslateAttribute(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TranslateAttribute component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TranslateAttribute(this);
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
        public TranslateAttribute.Builder TranslateAttribute()
        {
#if MVC
			return this.TranslateAttribute(new TranslateAttribute { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TranslateAttribute(new TranslateAttribute());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder TranslateAttribute(TranslateAttribute component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TranslateAttribute.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute.Builder TranslateAttribute(TranslateAttribute.Config config)
        {
#if MVC
			return new TranslateAttribute.Builder(new TranslateAttribute(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TranslateAttribute.Builder(new TranslateAttribute(config));
#endif			
        }
    }
}