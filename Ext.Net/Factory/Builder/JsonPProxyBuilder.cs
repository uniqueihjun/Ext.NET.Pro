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
    public partial class JsonPProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ServerProxy.Builder<JsonPProxy, JsonPProxy.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to automatically append the request's params to the generated url. Defaults to true
			/// </summary>
            public virtual JsonPProxy.Builder AutoAppendParams(bool autoAppendParams)
            {
                this.ToComponent().AutoAppendParams = autoAppendParams;
                return this as JsonPProxy.Builder;
            }
             
 			/// <summary>
			/// Specifies the GET parameter that will be sent to the server containing the function name to be executed when the request completes. Defaults to callback. Thus, a common request will be in the form of url?callback=Ext.data.JsonP.callback1
			/// </summary>
            public virtual JsonPProxy.Builder CallbackKey(string callbackKey)
            {
                this.ToComponent().CallbackKey = callbackKey;
                return this as JsonPProxy.Builder;
            }
             
 			/// <summary>
			/// The param name to use when passing records to the server (e.g. 'records=someEncodedRecordString'). Defaults to 'records'
			/// </summary>
            public virtual JsonPProxy.Builder RecordParam(string recordParam)
            {
                this.ToComponent().RecordParam = recordParam;
                return this as JsonPProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.JsonPProxy(this);
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
            return this.JsonPProxy(new JsonPProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder JsonPProxy(JsonPProxy component)
        {
            return new JsonPProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy.Builder JsonPProxy(JsonPProxy.Config config)
        {
            return new JsonPProxy.Builder(new JsonPProxy(config));
        }
    }
}