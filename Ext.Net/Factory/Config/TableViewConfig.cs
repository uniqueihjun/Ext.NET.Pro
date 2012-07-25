/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public abstract partial class TableView
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractDataView.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private JFunction getRowClass = null;

			/// <summary>
			/// Override this function to apply custom CSS classes to rows during rendering. You can also supply custom parameters to the row template for the current row to customize how it is rendered using the rowParams parameter. This function should return the CSS class name (or empty string '' for none) that will be added to the row's wrapping div. To apply multiple class names, simply return them space-delimited within the string (e.g., 'my-class another-class').
			/// </summary>
			public JFunction GetRowClass
			{
				get
				{
					if (this.getRowClass == null)
					{
						this.getRowClass = new JFunction();
					}
			
					return this.getRowClass;
				}
			}
			
			private bool enableTextSelection = false;

			/// <summary>
			/// True to enable text selections.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool EnableTextSelection 
			{ 
				get
				{
					return this.enableTextSelection;
				}
				set
				{
					this.enableTextSelection = value;
				}
			}

			private string firstCls = "x-grid-cell-first";

			/// <summary>
			/// A CSS class to add to the first cell in every row to enable special styling for the first column. If no styling is needed on the first column, this may be configured as null. Defaults to: \"x-grid-cell-first\"
			/// </summary>
			[DefaultValue("x-grid-cell-first")]
			public virtual string FirstCls 
			{ 
				get
				{
					return this.firstCls;
				}
				set
				{
					this.firstCls = value;
				}
			}

			private string lastCls = "x-grid-cell-last";

			/// <summary>
			/// A CSS class to add to the last cell in every row to enable special styling for the last column. If no styling is needed on the last column, this may be configured as null. Defaults to: \"x-grid-cell-last\"
			/// </summary>
			[DefaultValue("x-grid-cell-last")]
			public virtual string LastCls 
			{ 
				get
				{
					return this.lastCls;
				}
				set
				{
					this.lastCls = value;
				}
			}

			private bool markDirty = true;

			/// <summary>
			/// True to show the dirty cell indicator when a cell has been modified.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool MarkDirty 
			{ 
				get
				{
					return this.markDirty;
				}
				set
				{
					this.markDirty = value;
				}
			}

			private bool trackOver = true;

			/// <summary>
			/// True to enable mouseenter and mouseleave events
			/// </summary>
			[DefaultValue(true)]
			public override bool TrackOver 
			{ 
				get
				{
					return this.trackOver;
				}
				set
				{
					this.trackOver = value;
				}
			}

        }
    }
}