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
    public partial class ExclusionValidation
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TExclusionValidation, TBuilder> : AbstractValidation.Builder<TExclusionValidation, TBuilder>
            where TExclusionValidation : ExclusionValidation
            where TBuilder : Builder<TExclusionValidation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TExclusionValidation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ExclusionValidation.Builder<ExclusionValidation, ExclusionValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ExclusionValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ExclusionValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ExclusionValidation.Config config) : base(new ExclusionValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ExclusionValidation component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ExclusionValidation(this);
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
        public ExclusionValidation.Builder ExclusionValidation()
        {
#if MVC
			return this.ExclusionValidation(new ExclusionValidation { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ExclusionValidation(new ExclusionValidation());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ExclusionValidation(ExclusionValidation component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ExclusionValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation.Builder ExclusionValidation(ExclusionValidation.Config config)
        {
#if MVC
			return new ExclusionValidation.Builder(new ExclusionValidation(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ExclusionValidation.Builder(new ExclusionValidation(config));
#endif			
        }
    }
}