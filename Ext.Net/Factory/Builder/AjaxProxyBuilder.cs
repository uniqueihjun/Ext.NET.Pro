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
    public partial class AjaxProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAjaxProxy, TBuilder> : ServerProxy.Builder<TAjaxProxy, TBuilder>
            where TAjaxProxy : AjaxProxy
            where TBuilder : Builder<TAjaxProxy, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAjaxProxy component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Any headers to add to the Ajax request. Defaults to undefined.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Headers(Action<ParameterCollection> action)
            {
                action(this.ToComponent().Headers);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Send params as JSON object
			/// </summary>
            public virtual TBuilder Json(bool json)
            {
                this.ToComponent().Json = json;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Send params as XML object
			/// </summary>
            public virtual TBuilder Xml(bool xml)
            {
                this.ToComponent().Xml = xml;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Mapping of action name to HTTP request method. In the basic AjaxProxy these are set to 'GET' for 'read' actions and 'POST' for 'create', 'update' and 'destroy' actions. The Ext.data.proxy.Rest maps these to the correct RESTful methods.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder ActionMethods(Action<CRUDMethods> action)
            {
                action(this.ToComponent().ActionMethods);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Returns the HTTP method name for a given request. By default this returns based on a lookup on actionMethods.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetMethod(Action<JFunction> action)
            {
                action(this.ToComponent().GetMethod);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : AjaxProxy.Builder<AjaxProxy, AjaxProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AjaxProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AjaxProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AjaxProxy.Config config) : base(new AjaxProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AjaxProxy component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AjaxProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AjaxProxy(this);
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
        public AjaxProxy.Builder AjaxProxy()
        {
#if MVC
			return this.AjaxProxy(new AjaxProxy { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.AjaxProxy(new AjaxProxy());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public AjaxProxy.Builder AjaxProxy(AjaxProxy component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new AjaxProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AjaxProxy.Builder AjaxProxy(AjaxProxy.Config config)
        {
#if MVC
			return new AjaxProxy.Builder(new AjaxProxy(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new AjaxProxy.Builder(new AjaxProxy(config));
#endif			
        }
    }
}