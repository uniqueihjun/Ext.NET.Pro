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
    public partial class TreeGrid
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TreeGrid(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TreeGrid.Config Conversion to TreeGrid
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TreeGrid(TreeGrid.Config config)
        {
            return new TreeGrid(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TreePanel.Config 
        { 
			/*  Implicit TreeGrid.Config Conversion to TreeGrid.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TreeGrid.Builder(TreeGrid.Config config)
			{
				return new TreeGrid.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string autoExpandColumn = "";

			/// <summary>
			/// The index (or data index) of a column in this tree grid that should expand to fill unused space
			/// </summary>
			[DefaultValue("")]
			public virtual string AutoExpandColumn 
			{ 
				get
				{
					return this.autoExpandColumn;
				}
				set
				{
					this.autoExpandColumn = value;
				}
			}

			private Unit autoExpandMax = Unit.Pixel(1000);

			/// <summary>
			/// The maximum width the autoExpandColumn can have (if enabled). Defaults to 1000.
			/// </summary>
			[DefaultValue(typeof(Unit), "1000")]
			public virtual Unit AutoExpandMax 
			{ 
				get
				{
					return this.autoExpandMax;
				}
				set
				{
					this.autoExpandMax = value;
				}
			}

			private Unit autoExpandMin = Unit.Pixel(50);

			/// <summary>
			/// The minimum width the autoExpandColumn can have (if enabled). defaults to 50.
			/// </summary>
			[DefaultValue(typeof(Unit), "50")]
			public virtual Unit AutoExpandMin 
			{ 
				get
				{
					return this.autoExpandMin;
				}
				set
				{
					this.autoExpandMin = value;
				}
			}
        
			private TreeGridColumnCollection columns = null;

			/// <summary>
			/// An array of column configuration objects
			/// </summary>
			public TreeGridColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new TreeGridColumnCollection();
					}
			
					return this.columns;
				}
			}
			
			private bool hideHeaders = false;

			/// <summary>
			/// True to hide the grid's header (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideHeaders 
			{ 
				get
				{
					return this.hideHeaders;
				}
				set
				{
					this.hideHeaders = value;
				}
			}

        }
    }
}