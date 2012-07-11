/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class AxisLabel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit AxisLabel.Config Conversion to AxisLabel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AxisLabel(AxisLabel.Config config)
        {
            return new AxisLabel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : SpriteAttributes.Config 
        { 
			/*  Implicit AxisLabel.Config Conversion to AxisLabel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator AxisLabel.Builder(AxisLabel.Config config)
			{
				return new AxisLabel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private JFunction renderer = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction Renderer
			{
				get
				{
					if (this.renderer == null)
					{
						this.renderer = new JFunction();
					}
			
					return this.renderer;
				}
			}
			
			private int? padding = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual int? Padding 
			{ 
				get
				{
					return this.padding;
				}
				set
				{
					this.padding = value;
				}
			}

        }
    }
}