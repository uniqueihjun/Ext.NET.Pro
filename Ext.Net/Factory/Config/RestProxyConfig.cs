/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class RestProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RestProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RestProxy.Config Conversion to RestProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RestProxy(RestProxy.Config config)
        {
            return new RestProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AjaxProxy.Config 
        { 
			/*  Implicit RestProxy.Config Conversion to RestProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RestProxy.Builder(RestProxy.Config config)
			{
				return new RestProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool appendId = true;

			/// <summary>
			/// True to automatically append the ID of a Model instance when performing a request based on that single instance. See RestProxy intro docs for more details. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AppendId 
			{ 
				get
				{
					return this.appendId;
				}
				set
				{
					this.appendId = value;
				}
			}

			private string format = "";

			/// <summary>
			/// Optional data format to send to the server when making any request (e.g. 'json'). See the RestProxy intro docs for full details. Defaults to undefined.
			/// </summary>
			[DefaultValue("")]
			public virtual string Format 
			{ 
				get
				{
					return this.format;
				}
				set
				{
					this.format = value;
				}
			}

        }
    }
}