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
    public partial class ColumnLayout
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ColumnLayout(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ColumnLayout.Config Conversion to ColumnLayout
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColumnLayout(ColumnLayout.Config config)
        {
            return new ColumnLayout(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ContainerLayout.Config 
        { 
			/*  Implicit ColumnLayout.Config Conversion to ColumnLayout.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ColumnLayout.Builder(ColumnLayout.Config config)
			{
				return new ColumnLayout.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool fitHeight = true;

			/// <summary>
			/// True to fit the column elements height-wise into the Container. Defaults to false.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool FitHeight 
			{ 
				get
				{
					return this.fitHeight;
				}
				set
				{
					this.fitHeight = value;
				}
			}

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

			private int scrollOffset = 0;

			/// <summary>
			/// The amount of space to reserve for the scrollbar
			/// </summary>
			[DefaultValue(0)]
			public virtual int ScrollOffset 
			{ 
				get
				{
					return this.scrollOffset;
				}
				set
				{
					this.scrollOffset = value;
				}
			}
        
			private LayoutColumnCollection columns = null;

			/// <summary>
			/// Columns collection
			/// </summary>
			public LayoutColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new LayoutColumnCollection();
					}
			
					return this.columns;
				}
			}
			
        }
    }
}