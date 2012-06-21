/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
        new public abstract partial class Config : TablePanel.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool selectionSubmit = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool SelectionSubmit 
			{ 
				get
				{
					return this.selectionSubmit;
				}
				set
				{
					this.selectionSubmit = value;
				}
			}
        
			private ViewCollection<GridView> view = null;

			/// <summary>
			/// The Ext.grid.View used by the grid. This can be set before a call to render().
			/// </summary>
			public ViewCollection<GridView> View
			{
				get
				{
					if (this.view == null)
					{
						this.view = new ViewCollection<GridView>();
					}
			
					return this.view;
				}
			}
			        
			private GridScrollerCollection verticalScroller = null;

			/// <summary>
			/// 
			/// </summary>
			public GridScrollerCollection VerticalScroller
			{
				get
				{
					if (this.verticalScroller == null)
					{
						this.verticalScroller = new GridScrollerCollection();
					}
			
					return this.verticalScroller;
				}
			}
			        
			private StoreCollection<Store> store = null;

			/// <summary>
			/// The Ext.Net.Store the grid should use as its data source (required).
			/// </summary>
			public StoreCollection<Store> Store
			{
				get
				{
					if (this.store == null)
					{
						this.store = new StoreCollection<Store>();
					}
			
					return this.store;
				}
			}
			        
			private ItemsCollection<GridFeature> features = null;

			/// <summary>
			/// An array of grid features
			/// </summary>
			public ItemsCollection<GridFeature> Features
			{
				get
				{
					if (this.features == null)
					{
						this.features = new ItemsCollection<GridFeature>();
					}
			
					return this.features;
				}
			}
			
        }
    }
}