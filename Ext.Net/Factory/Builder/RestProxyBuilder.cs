/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class RestProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AjaxProxy.Builder<RestProxy, RestProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RestProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RestProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RestProxy.Config config) : base(new RestProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RestProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to automatically append the ID of a Model instance when performing a request based on that single instance. See RestProxy intro docs for more details. Defaults to true.
			/// </summary>
            public virtual RestProxy.Builder AppendId(bool appendId)
            {
                this.ToComponent().AppendId = appendId;
                return this as RestProxy.Builder;
            }
             
 			/// <summary>
			/// Optional data format to send to the server when making any request (e.g. 'json'). See the RestProxy intro docs for full details. Defaults to undefined.
			/// </summary>
            public virtual RestProxy.Builder Format(string format)
            {
                this.ToComponent().Format = format;
                return this as RestProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public RestProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RestProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public RestProxy.Builder RestProxy()
        {
            return this.RestProxy(new RestProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public RestProxy.Builder RestProxy(RestProxy component)
        {
            return new RestProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RestProxy.Builder RestProxy(RestProxy.Config config)
        {
            return new RestProxy.Builder(new RestProxy(config));
        }
    }
}