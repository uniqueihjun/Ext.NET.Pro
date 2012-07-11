/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class HttpProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataProxy.Builder<HttpProxy, HttpProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new HttpProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HttpProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(HttpProxy.Config config) : base(new HttpProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(HttpProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Whether a new request should abort any pending requests. (defaults to false)
			/// </summary>
            public virtual HttpProxy.Builder AutoAbort(bool autoAbort)
            {
                this.ToComponent().AutoAbort = autoAbort;
                return this as HttpProxy.Builder;
            }
             
 			// /// <summary>
			// /// An object containing request headers which are added to each request made by this object.
			// /// </summary>
            // public virtual TBuilder Headers(ParameterCollection headers)
            // {
            //    this.ToComponent().Headers = headers;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// True to add a unique cache-buster param to GET requests. (defaults to true)
			/// </summary>
            public virtual HttpProxy.Builder DisableCaching(bool disableCaching)
            {
                this.ToComponent().DisableCaching = disableCaching;
                return this as HttpProxy.Builder;
            }
             
 			/// <summary>
			/// The default HTTP method to be used for requests.
			/// </summary>
            public virtual HttpProxy.Builder Method(HttpMethod method)
            {
                this.ToComponent().Method = method;
                return this as HttpProxy.Builder;
            }
             
 			/// <summary>
			/// The timeout in milliseconds to be used for requests. (defaults to 30000)
			/// </summary>
            public virtual HttpProxy.Builder Timeout(int timeout)
            {
                this.ToComponent().Timeout = timeout;
                return this as HttpProxy.Builder;
            }
             
 			/// <summary>
			/// The default URL to be used for requests to the server.
			/// </summary>
            public virtual HttpProxy.Builder Url(string url)
            {
                this.ToComponent().Url = url;
                return this as HttpProxy.Builder;
            }
             
 			/// <summary>
			/// Send params as JSON object
			/// </summary>
            public virtual HttpProxy.Builder Json(bool json)
            {
                this.ToComponent().Json = json;
                return this as HttpProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public HttpProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.HttpProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public HttpProxy.Builder HttpProxy()
        {
            return this.HttpProxy(new HttpProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public HttpProxy.Builder HttpProxy(HttpProxy component)
        {
            return new HttpProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public HttpProxy.Builder HttpProxy(HttpProxy.Config config)
        {
            return new HttpProxy.Builder(new HttpProxy(config));
        }
    }
}