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
    public partial class UuidIdGenerator
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public UuidIdGenerator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit UuidIdGenerator.Config Conversion to UuidIdGenerator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UuidIdGenerator(UuidIdGenerator.Config config)
        {
            return new UuidIdGenerator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ModelIdGenerator.Config 
        { 
			/*  Implicit UuidIdGenerator.Config Conversion to UuidIdGenerator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator UuidIdGenerator.Builder(UuidIdGenerator.Config config)
			{
				return new UuidIdGenerator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}