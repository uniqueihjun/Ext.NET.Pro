/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class FormatValidation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FormatValidation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FormatValidation.Config Conversion to FormatValidation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FormatValidation(FormatValidation.Config config)
        {
            return new FormatValidation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractValidation.Config 
        { 
			/*  Implicit FormatValidation.Config Conversion to FormatValidation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FormatValidation.Builder(FormatValidation.Config config)
			{
				return new FormatValidation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string regex = "";

			/// <summary>
			/// A JavaScript RegExp object to be tested against the value
			/// </summary>
			[DefaultValue("")]
			public virtual string Regex 
			{ 
				get
				{
					return this.regex;
				}
				set
				{
					this.regex = value;
				}
			}

        }
    }
}