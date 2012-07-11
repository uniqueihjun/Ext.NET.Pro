/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class SliderField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SliderField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SliderField.Config Conversion to SliderField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SliderField(SliderField.Config config)
        {
            return new SliderField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Field.Config 
        { 
			/*  Implicit SliderField.Config Conversion to SliderField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SliderField.Builder(SliderField.Config config)
			{
				return new SliderField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private Slider slider = null;

			/// <summary>
			/// Slider object config
			/// </summary>
			public Slider Slider
			{
				get
				{
					if (this.slider == null)
					{
						this.slider = new Slider();
					}
			
					return this.slider;
				}
			}
			
        }
    }
}