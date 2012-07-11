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
    public partial class RowLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RowLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RowLayout.Config Conversion to RowLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RowLayout(RowLayout.Config config)
        {
            return new RowLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit RowLayout.Config Conversion to RowLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RowLayout.Builder(RowLayout.Config config)
			{
				return new RowLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool background = false;

			/// <summary>
			/// True to fill background by predefined color. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Background 
			{ 
				get
				{
					return this.background;
				}
				set
				{
					this.background = value;
				}
			}

			private bool split = false;

			/// <summary>
			/// True to allow resizing of the columns using a SplitBar. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Split 
			{ 
				get
				{
					return this.split;
				}
				set
				{
					this.split = value;
				}
			}

			private int margin = 0;

			/// <summary>
			/// Width of margin between columns in pixels. Overrides any style settings. Defaults to 0.
			/// </summary>
			[DefaultValue(0)]
			public virtual int Margin 
			{ 
				get
				{
					return this.margin;
				}
				set
				{
					this.margin = value;
				}
			}

        }
    }
}