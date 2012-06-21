/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class FieldReplicator
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FieldReplicator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FieldReplicator.Config Conversion to FieldReplicator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FieldReplicator(FieldReplicator.Config config)
        {
            return new FieldReplicator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit FieldReplicator.Config Conversion to FieldReplicator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FieldReplicator.Builder(FieldReplicator.Config config)
			{
				return new FieldReplicator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}