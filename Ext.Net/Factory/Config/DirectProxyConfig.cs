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
    public partial class DirectProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DirectProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DirectProxy.Config Conversion to DirectProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DirectProxy(DirectProxy.Config config)
        {
            return new DirectProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ServerProxy.Config 
        { 
			/*  Implicit DirectProxy.Config Conversion to DirectProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DirectProxy.Builder(DirectProxy.Config config)
			{
				return new DirectProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private CRUDUrls aPI = null;

			/// <summary>
			/// Specific direct functions to call on CRUD action methods \"read\", \"create\", \"update\" and \"destroy\".
			/// </summary>
			public CRUDUrls API
			{
				get
				{
					if (this.aPI == null)
					{
						this.aPI = new CRUDUrls();
					}
			
					return this.aPI;
				}
			}
			        
			private JFunction directFn = null;

			/// <summary>
			/// Function to call when executing a request. directFn is a simple alternative to defining the api configuration-parameter for Store's which will not implement a full CRUD api.
			/// </summary>
			public JFunction DirectFn
			{
				get
				{
					if (this.directFn == null)
					{
						this.directFn = new JFunction();
					}
			
					return this.directFn;
				}
			}
			
			private string paramOrder = "";

			/// <summary>
			/// Defaults to undefined. A list of params to be executed server side. Specify the params in the order in which they must be executed on the server-side as a String of params delimited by either whitespace, comma, or pipe.
			/// </summary>
			[DefaultValue("")]
			public virtual string ParamOrder 
			{ 
				get
				{
					return this.paramOrder;
				}
				set
				{
					this.paramOrder = value;
				}
			}

			private bool paramsAsHash = true;

			/// <summary>
			/// Send parameters as a collection of named arguments (defaults to true). Providing a paramOrder nullifies this configuration.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ParamsAsHash 
			{ 
				get
				{
					return this.paramsAsHash;
				}
				set
				{
					this.paramsAsHash = value;
				}
			}

        }
    }
}