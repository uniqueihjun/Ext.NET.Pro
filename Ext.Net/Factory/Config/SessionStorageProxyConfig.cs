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
    public partial class SessionStorageProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SessionStorageProxy.Config Conversion to SessionStorageProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionStorageProxy(SessionStorageProxy.Config config)
        {
            return new SessionStorageProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : WebStorageProxy.Config 
        { 
			/*  Implicit SessionStorageProxy.Config Conversion to SessionStorageProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SessionStorageProxy.Builder(SessionStorageProxy.Config config)
			{
				return new SessionStorageProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}