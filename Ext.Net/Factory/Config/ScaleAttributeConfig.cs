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
    public partial class ScaleAttribute
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ScaleAttribute(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ScaleAttribute.Config Conversion to ScaleAttribute
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScaleAttribute(ScaleAttribute.Config config)
        {
            return new ScaleAttribute(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TranslateAttribute.Config 
        { 
			/*  Implicit ScaleAttribute.Config Conversion to ScaleAttribute.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ScaleAttribute.Builder(ScaleAttribute.Config config)
			{
				return new ScaleAttribute.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private double? cX = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual double? CX 
			{ 
				get
				{
					return this.cX;
				}
				set
				{
					this.cX = value;
				}
			}

			private double? cY = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual double? CY 
			{ 
				get
				{
					return this.cY;
				}
				set
				{
					this.cY = value;
				}
			}

        }
    }
}