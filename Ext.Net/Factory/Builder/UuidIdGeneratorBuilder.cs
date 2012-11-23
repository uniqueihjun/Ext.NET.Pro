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
    public partial class UuidIdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TUuidIdGenerator, TBuilder> : ModelIdGenerator.Builder<TUuidIdGenerator, TBuilder>
            where TUuidIdGenerator : UuidIdGenerator
            where TBuilder : Builder<TUuidIdGenerator, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TUuidIdGenerator component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : UuidIdGenerator.Builder<UuidIdGenerator, UuidIdGenerator.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new UuidIdGenerator()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UuidIdGenerator component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UuidIdGenerator.Config config) : base(new UuidIdGenerator(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(UuidIdGenerator component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.UuidIdGenerator(this);
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
        public UuidIdGenerator.Builder UuidIdGenerator()
        {
#if MVC
			return this.UuidIdGenerator(new UuidIdGenerator { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.UuidIdGenerator(new UuidIdGenerator());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder UuidIdGenerator(UuidIdGenerator component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new UuidIdGenerator.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator.Builder UuidIdGenerator(UuidIdGenerator.Config config)
        {
#if MVC
			return new UuidIdGenerator.Builder(new UuidIdGenerator(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new UuidIdGenerator.Builder(new UuidIdGenerator(config));
#endif			
        }
    }
}