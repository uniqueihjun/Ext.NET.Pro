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
    public partial class FieldContainer
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TFieldContainer, TBuilder> : FieldContainerBase.Builder<TFieldContainer, TBuilder>
            where TFieldContainer : FieldContainer
            where TBuilder : Builder<TFieldContainer, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TFieldContainer component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<FieldContainerListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<FieldContainerDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : FieldContainer.Builder<FieldContainer, FieldContainer.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldContainer()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldContainer component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldContainer.Config config) : base(new FieldContainer(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldContainer component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldContainer(this);
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
        public FieldContainer.Builder FieldContainer()
        {
#if MVC
			return this.FieldContainer(new FieldContainer { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.FieldContainer(new FieldContainer());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder FieldContainer(FieldContainer component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new FieldContainer.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer.Builder FieldContainer(FieldContainer.Config config)
        {
#if MVC
			return new FieldContainer.Builder(new FieldContainer(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new FieldContainer.Builder(new FieldContainer(config));
#endif			
        }
    }
}