/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class VBoxLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public VBoxLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit VBoxLayout.Config Conversion to VBoxLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VBoxLayout(VBoxLayout.Config config)
        {
            return new VBoxLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BoxLayout.Config 
        { 
			/*  Implicit VBoxLayout.Config Conversion to VBoxLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator VBoxLayout.Builder(VBoxLayout.Config config)
			{
				return new VBoxLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private VBoxAlign align = VBoxAlign.Left;

			/// <summary>
			/// Controls how the child items of the container are aligned.
			/// </summary>
			[DefaultValue(VBoxAlign.Left)]
			public virtual VBoxAlign Align 
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