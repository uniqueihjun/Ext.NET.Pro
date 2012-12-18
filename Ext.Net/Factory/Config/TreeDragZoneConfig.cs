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
    public partial class TreeDragZone
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TreeDragZone.Config Conversion to TreeDragZone
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TreeDragZone(TreeDragZone.Config config)
        {
            return new TreeDragZone(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DragZone.Config 
        { 
			/*  Implicit TreeDragZone.Config Conversion to TreeDragZone.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TreeDragZone.Builder(TreeDragZone.Config config)
			{
				return new TreeDragZone.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}