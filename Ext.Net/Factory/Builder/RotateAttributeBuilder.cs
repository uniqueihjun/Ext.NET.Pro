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
    public partial class RotateAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRotateAttribute, TBuilder> : TranslateAttribute.Builder<TRotateAttribute, TBuilder>
            where TRotateAttribute : RotateAttribute
            where TBuilder : Builder<TRotateAttribute, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRotateAttribute component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Degrees(int? degrees)
            {
                this.ToComponent().Degrees = degrees;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RotateAttribute.Builder<RotateAttribute, RotateAttribute.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RotateAttribute()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RotateAttribute component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RotateAttribute.Config config) : base(new RotateAttribute(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RotateAttribute component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RotateAttribute(this);
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
        public RotateAttribute.Builder RotateAttribute()
        {
#if MVC
			return this.RotateAttribute(new RotateAttribute { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RotateAttribute(new RotateAttribute());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder RotateAttribute(RotateAttribute component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RotateAttribute.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute.Builder RotateAttribute(RotateAttribute.Config config)
        {
#if MVC
			return new RotateAttribute.Builder(new RotateAttribute(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RotateAttribute.Builder(new RotateAttribute(config));
#endif			
        }
    }
}