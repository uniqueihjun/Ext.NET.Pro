/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class DirectProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ServerProxy.Builder<DirectProxy, DirectProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DirectProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DirectProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DirectProxy.Config config) : base(new DirectProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DirectProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Specific direct functions to call on CRUD action methods \"read\", \"create\", \"update\" and \"destroy\".
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DirectProxy.Builder</returns>
            public virtual DirectProxy.Builder API(Action<CRUDUrls> action)
            {
                action(this.ToComponent().API);
                return this as DirectProxy.Builder;
            }
			 
 			/// <summary>
			/// Function to call when executing a request. directFn is a simple alternative to defining the api configuration-parameter for Store's which will not implement a full CRUD api.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DirectProxy.Builder</returns>
            public virtual DirectProxy.Builder DirectFn(Action<JFunction> action)
            {
                action(this.ToComponent().DirectFn);
                return this as DirectProxy.Builder;
            }
			 
 			/// <summary>
			/// Defaults to undefined. A list of params to be executed server side. Specify the params in the order in which they must be executed on the server-side as a String of params delimited by either whitespace, comma, or pipe.
			/// </summary>
            public virtual DirectProxy.Builder ParamOrder(string paramOrder)
            {
                this.ToComponent().ParamOrder = paramOrder;
                return this as DirectProxy.Builder;
            }
             
 			/// <summary>
			/// Send parameters as a collection of named arguments (defaults to true). Providing a paramOrder nullifies this configuration.
			/// </summary>
            public virtual DirectProxy.Builder ParamsAsHash(bool paramsAsHash)
            {
                this.ToComponent().ParamsAsHash = paramsAsHash;
                return this as DirectProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DirectProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DirectProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DirectProxy.Builder DirectProxy()
        {
            return this.DirectProxy(new DirectProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public DirectProxy.Builder DirectProxy(DirectProxy component)
        {
            return new DirectProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DirectProxy.Builder DirectProxy(DirectProxy.Config config)
        {
            return new DirectProxy.Builder(new DirectProxy(config));
        }
    }
}