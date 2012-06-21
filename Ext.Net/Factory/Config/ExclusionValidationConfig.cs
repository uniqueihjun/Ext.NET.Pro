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
    public partial class ExclusionValidation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ExclusionValidation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ExclusionValidation.Config Conversion to ExclusionValidation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExclusionValidation(ExclusionValidation.Config config)
        {
            return new ExclusionValidation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractValidation.Config 
        { 
			/*  Implicit ExclusionValidation.Config Conversion to ExclusionValidation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ExclusionValidation.Builder(ExclusionValidation.Config config)
			{
				return new ExclusionValidation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}