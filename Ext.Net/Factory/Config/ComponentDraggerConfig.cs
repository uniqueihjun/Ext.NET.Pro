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
    public partial class ComponentDragger
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ComponentDragger(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ComponentDragger.Config Conversion to ComponentDragger
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComponentDragger(ComponentDragger.Config config)
        {
            return new ComponentDragger(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DragTracker.Config 
        { 
			/*  Implicit ComponentDragger.Config Conversion to ComponentDragger.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ComponentDragger.Builder(ComponentDragger.Config config)
			{
				return new ComponentDragger.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}