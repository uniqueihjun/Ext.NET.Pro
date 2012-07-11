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
    public abstract partial class TableView
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TTableView, TBuilder> : AbstractDataView.Builder<TTableView, TBuilder>
            where TTableView : TableView
            where TBuilder : Builder<TTableView, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTableView component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Override this function to apply custom CSS classes to rows during rendering. You can also supply custom parameters to the row template for the current row to customize how it is rendered using the rowParams parameter. This function should return the CSS class name (or empty string '' for none) that will be added to the row's wrapping div. To apply multiple class names, simply return them space-delimited within the string (e.g., 'my-class another-class').
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder GetRowClass(Action<JFunction> action)
            {
                action(this.ToComponent().GetRowClass);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// True to enable text selections.
			/// </summary>
            public virtual TBuilder EnableTextSelection(bool enableTextSelection)
            {
                this.ToComponent().EnableTextSelection = enableTextSelection;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A CSS class to add to the first cell in every row to enable special styling for the first column. If no styling is needed on the first column, this may be configured as null. Defaults to: \"x-grid-cell-first\"
			/// </summary>
            public virtual TBuilder FirstCls(string firstCls)
            {
                this.ToComponent().FirstCls = firstCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A CSS class to add to the last cell in every row to enable special styling for the last column. If no styling is needed on the last column, this may be configured as null. Defaults to: \"x-grid-cell-last\"
			/// </summary>
            public virtual TBuilder LastCls(string lastCls)
            {
                this.ToComponent().LastCls = lastCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to show the dirty cell indicator when a cell has been modified.
			/// </summary>
            public virtual TBuilder MarkDirty(bool markDirty)
            {
                this.ToComponent().MarkDirty = markDirty;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to enable mouseenter and mouseleave events
			/// </summary>
            public virtual TBuilder TrackOver(bool trackOver)
            {
                this.ToComponent().TrackOver = trackOver;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}