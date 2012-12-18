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
    public partial class InclusionValidation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public InclusionValidation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit InclusionValidation.Config Conversion to InclusionValidation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InclusionValidation(InclusionValidation.Config config)
        {
            return new InclusionValidation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractValidation.Config 
        { 
			/*  Implicit InclusionValidation.Config Conversion to InclusionValidation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator InclusionValidation.Builder(InclusionValidation.Config config)
			{
				return new InclusionValidation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
        }
    }
}