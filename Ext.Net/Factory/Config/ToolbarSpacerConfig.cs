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
    public partial class ToolbarSpacer
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ToolbarSpacer.Config Conversion to ToolbarSpacer
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolbarSpacer(ToolbarSpacer.Config config)
        {
            return new ToolbarSpacer(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarItem.Config 
        { 
			/*  Implicit ToolbarSpacer.Config Conversion to ToolbarSpacer.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ToolbarSpacer.Builder(ToolbarSpacer.Config config)
			{
				return new ToolbarSpacer.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}