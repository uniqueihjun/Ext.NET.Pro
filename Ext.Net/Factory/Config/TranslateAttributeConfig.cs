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
    public partial class TranslateAttribute
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TranslateAttribute(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TranslateAttribute.Config Conversion to TranslateAttribute
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranslateAttribute(TranslateAttribute.Config config)
        {
            return new TranslateAttribute(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit TranslateAttribute.Config Conversion to TranslateAttribute.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TranslateAttribute.Builder(TranslateAttribute.Config config)
			{
				return new TranslateAttribute.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private double? x = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual double? X 
			{ 
				get
				{
					return this.x;
				}
				set
				{
					this.x = value;
				}
			}

			private double? y = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual double? Y 
			{ 
				get
				{
					return this.y;
				}
				set
				{
					this.y = value;
				}
			}

        }
    }
}