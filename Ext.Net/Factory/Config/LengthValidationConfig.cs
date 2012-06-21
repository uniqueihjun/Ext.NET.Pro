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
    public partial class LengthValidation
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public LengthValidation(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit LengthValidation.Config Conversion to LengthValidation
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LengthValidation(LengthValidation.Config config)
        {
            return new LengthValidation(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractValidation.Config 
        { 
			/*  Implicit LengthValidation.Config Conversion to LengthValidation.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator LengthValidation.Builder(LengthValidation.Config config)
			{
				return new LengthValidation.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int max = int.MaxValue;

			/// <summary>
			/// Maximum value length allowed.
			/// </summary>
			[DefaultValue(int.MaxValue)]
			public virtual int Max 
			{ 
				get
				{
					return this.max;
				}
				set
				{
					this.max = value;
				}
			}

			private int min = int.MinValue;

			/// <summary>
			/// Minimum value length allowed.
			/// </summary>
			[DefaultValue(int.MinValue)]
			public virtual int Min 
			{ 
				get
				{
					return this.min;
				}
				set
				{
					this.min = value;
				}
			}

        }
    }
}