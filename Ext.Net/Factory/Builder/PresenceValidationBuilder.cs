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
    public partial class PresenceValidation
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPresenceValidation, TBuilder> : AbstractValidation.Builder<TPresenceValidation, TBuilder>
            where TPresenceValidation : PresenceValidation
            where TBuilder : Builder<TPresenceValidation, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPresenceValidation component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : PresenceValidation.Builder<PresenceValidation, PresenceValidation.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PresenceValidation()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PresenceValidation component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PresenceValidation.Config config) : base(new PresenceValidation(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PresenceValidation component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PresenceValidation(this);
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
        public PresenceValidation.Builder PresenceValidation()
        {
#if MVC
			return this.PresenceValidation(new PresenceValidation { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.PresenceValidation(new PresenceValidation());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder PresenceValidation(PresenceValidation component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new PresenceValidation.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PresenceValidation.Builder PresenceValidation(PresenceValidation.Config config)
        {
#if MVC
			return new PresenceValidation.Builder(new PresenceValidation(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new PresenceValidation.Builder(new PresenceValidation(config));
#endif			
        }
    }
}