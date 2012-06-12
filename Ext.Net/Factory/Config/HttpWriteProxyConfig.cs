/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class HttpWriteProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HttpWriteProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HttpWriteProxy.Config Conversion to HttpWriteProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HttpWriteProxy(HttpWriteProxy.Config config)
        {
            return new HttpWriteProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : HttpProxy.Config 
        { 
			/*  Implicit HttpWriteProxy.Config Conversion to HttpWriteProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HttpWriteProxy.Builder(HttpWriteProxy.Config config)
			{
				return new HttpWriteProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool handleSaveResponseAsXml = false;

			/// <summary>
			/// If save handler is web service then response will be xml. This option specifies how to handle response.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HandleSaveResponseAsXml 
			{ 
				get
				{
					return this.handleSaveResponseAsXml;
				}
				set
				{
					this.handleSaveResponseAsXml = value;
				}
			}

        }
    }
}