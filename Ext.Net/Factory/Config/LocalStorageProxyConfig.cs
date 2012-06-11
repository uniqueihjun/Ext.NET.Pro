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
    public partial class LocalStorageProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public LocalStorageProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit LocalStorageProxy.Config Conversion to LocalStorageProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LocalStorageProxy(LocalStorageProxy.Config config)
        {
            return new LocalStorageProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : WebStorageProxy.Config 
        { 
			/*  Implicit LocalStorageProxy.Config Conversion to LocalStorageProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator LocalStorageProxy.Builder(LocalStorageProxy.Config config)
			{
				return new LocalStorageProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}