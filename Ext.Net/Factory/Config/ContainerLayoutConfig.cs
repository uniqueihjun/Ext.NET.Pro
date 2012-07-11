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
    public partial class ContainerLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ContainerLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ContainerLayout.Config Conversion to ContainerLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContainerLayout(ContainerLayout.Config config)
        {
            return new ContainerLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Layout.Config 
        { 
			/*  Implicit ContainerLayout.Config Conversion to ContainerLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ContainerLayout.Builder(ContainerLayout.Config config)
			{
				return new ContainerLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}