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
    public partial class LengthValidation
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TLengthValidation, TBuilder> : AbstractValidation.Builder<TLengthValidation, TBuilder>
            where TLengthValidation : LengthValidation
            where TBuilder : Builder<TLengthValidation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TLengthValidation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Maximum value length allowed.
			/// </summary>
            public virtual TBuilder Max(int max)
            {
                this.ToComponent().Max = max;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Minimum value length allowed.
			/// </summary>
            public virtual TBuilder Min(int min)
            {
                this.ToComponent().Min = min;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : LengthValidation.Builder<LengthValidation, LengthValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LengthValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LengthValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LengthValidation.Config config) : base(new LengthValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LengthValidation component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LengthValidation(this);
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
        public LengthValidation.Builder LengthValidation()
        {
#if MVC
			return this.LengthValidation(new LengthValidation { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.LengthValidation(new LengthValidation());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder LengthValidation(LengthValidation component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new LengthValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation.Builder LengthValidation(LengthValidation.Config config)
        {
#if MVC
			return new LengthValidation.Builder(new LengthValidation(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new LengthValidation.Builder(new LengthValidation(config));
#endif			
        }
    }
}