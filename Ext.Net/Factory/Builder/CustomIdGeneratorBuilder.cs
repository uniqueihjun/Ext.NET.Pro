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
    public partial class CustomIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCustomIdGenerator, TBuilder> : ModelIdGenerator.Builder<TCustomIdGenerator, TBuilder>
            where TCustomIdGenerator : CustomIdGenerator
            where TBuilder : Builder<TCustomIdGenerator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCustomIdGenerator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Generate(Action<JFunction> action)
            {
                action(this.ToComponent().Generate);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CustomIdGenerator.Builder<CustomIdGenerator, CustomIdGenerator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CustomIdGenerator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CustomIdGenerator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CustomIdGenerator.Config config) : base(new CustomIdGenerator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CustomIdGenerator component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CustomIdGenerator(this);
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
        public CustomIdGenerator.Builder CustomIdGenerator()
        {
#if MVC
			return this.CustomIdGenerator(new CustomIdGenerator { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CustomIdGenerator(new CustomIdGenerator());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder CustomIdGenerator(CustomIdGenerator component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CustomIdGenerator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomIdGenerator.Builder CustomIdGenerator(CustomIdGenerator.Config config)
        {
#if MVC
			return new CustomIdGenerator.Builder(new CustomIdGenerator(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CustomIdGenerator.Builder(new CustomIdGenerator(config));
#endif			
        }
    }
}