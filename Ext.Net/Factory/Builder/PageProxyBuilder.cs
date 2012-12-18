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
    public partial class PageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPageProxy, TBuilder> : ServerProxy.Builder<TPageProxy, TBuilder>
            where TPageProxy : PageProxy
            where TBuilder : Builder<TPageProxy, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPageProxy component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Total(int total)
            {
                this.ToComponent().Total = total;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DirectFn(string directFn)
            {
                this.ToComponent().DirectFn = directFn;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder RequestConfig(Action<BaseDirectEvent> action)
            {
                action(this.ToComponent().RequestConfig);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : PageProxy.Builder<PageProxy, PageProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PageProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PageProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PageProxy.Config config) : base(new PageProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PageProxy component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PageProxy(this);
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
        public PageProxy.Builder PageProxy()
        {
#if MVC
			return this.PageProxy(new PageProxy { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.PageProxy(new PageProxy());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder PageProxy(PageProxy component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new PageProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PageProxy.Builder PageProxy(PageProxy.Config config)
        {
#if MVC
			return new PageProxy.Builder(new PageProxy(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new PageProxy.Builder(new PageProxy(config));
#endif			
        }
    }
}