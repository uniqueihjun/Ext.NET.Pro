/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class SplitCommand
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SplitCommand(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SplitCommand.Config Conversion to SplitCommand
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SplitCommand(SplitCommand.Config config)
        {
            return new SplitCommand(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridCommand.Config 
        { 
			/*  Implicit SplitCommand.Config Conversion to SplitCommand.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SplitCommand.Builder(SplitCommand.Config config)
			{
				return new SplitCommand.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}