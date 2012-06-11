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
    public partial class RotateAttribute
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RotateAttribute(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RotateAttribute.Config Conversion to RotateAttribute
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RotateAttribute(RotateAttribute.Config config)
        {
            return new RotateAttribute(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TranslateAttribute.Config 
        { 
			/*  Implicit RotateAttribute.Config Conversion to RotateAttribute.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RotateAttribute.Builder(RotateAttribute.Config config)
			{
				return new RotateAttribute.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int? degrees = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual int? Degrees 
			{ 
				get
				{
					return this.degrees;
				}
				set
				{
					this.degrees = value;
				}
			}

        }
    }
}