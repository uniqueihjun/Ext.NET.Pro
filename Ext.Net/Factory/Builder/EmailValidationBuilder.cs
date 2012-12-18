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
    public partial class EmailValidation
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TEmailValidation, TBuilder> : AbstractValidation.Builder<TEmailValidation, TBuilder>
            where TEmailValidation : EmailValidation
            where TBuilder : Builder<TEmailValidation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TEmailValidation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : EmailValidation.Builder<EmailValidation, EmailValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new EmailValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EmailValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EmailValidation.Config config) : base(new EmailValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(EmailValidation component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EmailValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EmailValidation(this);
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
        public EmailValidation.Builder EmailValidation()
        {
#if MVC
			return this.EmailValidation(new EmailValidation { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.EmailValidation(new EmailValidation());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public EmailValidation.Builder EmailValidation(EmailValidation component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new EmailValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EmailValidation.Builder EmailValidation(EmailValidation.Config config)
        {
#if MVC
			return new EmailValidation.Builder(new EmailValidation(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new EmailValidation.Builder(new EmailValidation(config));
#endif			
        }
    }
}