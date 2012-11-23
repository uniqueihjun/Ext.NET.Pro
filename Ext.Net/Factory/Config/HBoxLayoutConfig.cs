/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class HBoxLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HBoxLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HBoxLayout.Config Conversion to HBoxLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HBoxLayout(HBoxLayout.Config config)
        {
            return new HBoxLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BoxLayout.Config 
        { 
			/*  Implicit HBoxLayout.Config Conversion to HBoxLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HBoxLayout.Builder(HBoxLayout.Config config)
			{
				return new HBoxLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private HBoxAlign align = HBoxAlign.Top;

			/// <summary>
			/// Controls how the child items of the container are aligned.
			/// </summary>
			[DefaultValue(HBoxAlign.Top)]
			public virtual HBoxAlign Align 
			{ 
				get
				{
					return this.align;
				}
				set
				{
					this.align = value;
				}
			}

        }
    }
}