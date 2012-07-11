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
    public partial class LinkButton
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public LinkButton(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit LinkButton.Config Conversion to LinkButton
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LinkButton(LinkButton.Config config)
        {
            return new LinkButton(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Button.Config 
        { 
			/*  Implicit LinkButton.Config Conversion to LinkButton.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator LinkButton.Builder(LinkButton.Config config)
			{
				return new LinkButton.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}