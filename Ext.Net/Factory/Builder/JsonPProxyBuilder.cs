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
    public partial class JsonPProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TJsonPProxy, TBuilder> : ServerProxy.Builder<TJsonPProxy, TBuilder>
            where TJsonPProxy : JsonPProxy
            where TBuilder : Builder<TJsonPProxy, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TJsonPProxy component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to automatically append the request's params to the generated url. Defaults to true
			/// </summary>
            public virtual TBuilder AutoAppendParams(bool autoAppendParams)
            {
                this.ToComponent().AutoAppendParams = autoAppendParams;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Specifies the GET parameter that will be sent to the server containing the function name to be executed when the request completes. Defaults to callback. Thus, a common request will be in the form of url?callback=Ext.data.JsonP.callback1
			/// </summary>
            public virtual TBuilder CallbackKey(string callbackKey)
            {
                this.ToComponent().CallbackKey = callbackKey;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The param name to use when passing records to the server (e.g. 'records=someEncodedRecordString'). Defaults to 'records'
			/// </summary>
            public virtual TBuilder RecordParam(string recordParam)
            {
                this.ToComponent().RecordParam = recordParam;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : JsonPProxy.Builder<JsonPProxy, JsonPProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new JsonPProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonPProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(JsonPProxy.Config config) : base(new JsonPProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(JsonPProxy component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.JsonPProxy(this);
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
        public JsonPProxy.Builder JsonPProxy()
        {
#if MVC
			return this.JsonPProxy(new JsonPProxy { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.JsonPProxy(new JsonPProxy());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder JsonPProxy(JsonPProxy component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new JsonPProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder JsonPProxy(JsonPProxy.Config config)
        {
#if MVC
			return new JsonPProxy.Builder(new JsonPProxy(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new JsonPProxy.Builder(new JsonPProxy(config));
#endif			
        }
    }
}