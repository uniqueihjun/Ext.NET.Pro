/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class GenericComponent<T>
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GenericComponent<T>(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GenericComponent<T>.Config Conversion to GenericComponent<T>
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenericComponent<T>(GenericComponent<T>.Config config)
        {
            return new GenericComponent<T>(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Component.Config 
        { 
			/*  Implicit GenericComponent<T>.Config Conversion to GenericComponent<T>.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GenericComponent<T>.Builder(GenericComponent<T>.Config config)
			{
				return new GenericComponent<T>.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}