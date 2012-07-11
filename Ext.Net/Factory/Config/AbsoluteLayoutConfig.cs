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
    public partial class AbsoluteLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AbsoluteLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AbsoluteLayout.Config Conversion to AbsoluteLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AbsoluteLayout(AbsoluteLayout.Config config)
        {
            return new AbsoluteLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AnchorLayout.Config 
        { 
			/*  Implicit AbsoluteLayout.Config Conversion to AbsoluteLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AbsoluteLayout.Builder(AbsoluteLayout.Config config)
			{
				return new AbsoluteLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}