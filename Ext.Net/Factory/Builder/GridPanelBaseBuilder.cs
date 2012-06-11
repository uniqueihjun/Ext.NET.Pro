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
    public abstract partial class GridPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TGridPanelBase, TBuilder> : TablePanel.Builder<TGridPanelBase, TBuilder>
            where TGridPanelBase : GridPanelBase
            where TBuilder : Builder<TGridPanelBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGridPanelBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SelectionSubmit(bool selectionSubmit)
            {
                this.ToComponent().SelectionSubmit = selectionSubmit;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The Ext.grid.View used by the grid. This can be set before a call to render().
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder View(Action<ViewCollection<GridView>> action)
            {
                action(this.ToComponent().View);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder VerticalScroller(Action<GridScrollerCollection> action)
            {
                action(this.ToComponent().VerticalScroller);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// The Ext.Net.Store the grid should use as its data source (required).
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Store(Action<StoreCollection<Store>> action)
            {
                action(this.ToComponent().Store);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// An array of grid features
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Features(Action<ItemsCollection<GridFeature>> action)
            {
                action(this.ToComponent().Features);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}