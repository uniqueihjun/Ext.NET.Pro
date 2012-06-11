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
    public partial class DrawBackground
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DrawBackground.Config Conversion to DrawBackground
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DrawBackground(DrawBackground.Config config)
        {
            return new DrawBackground(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit DrawBackground.Config Conversion to DrawBackground.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DrawBackground.Builder(DrawBackground.Config config)
			{
				return new DrawBackground.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string fill = "";

			/// <summary>
			/// The fill color
			/// </summary>
			[DefaultValue("")]
			public virtual string Fill 
			{ 
				get
				{
					return this.fill;
				}
				set
				{
					this.fill = value;
				}
			}

			private string image = "";

			/// <summary>
			/// The background image
			/// </summary>
			[DefaultValue("")]
			public virtual string Image 
			{ 
				get
				{
					return this.image;
				}
				set
				{
					this.image = value;
				}
			}

			private Gradient gradient = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual Gradient Gradient 
			{ 
				get
				{
					return this.gradient;
				}
				set
				{
					this.gradient = value;
				}
			}

        }
    }
}