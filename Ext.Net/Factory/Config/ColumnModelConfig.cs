/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class ColumnModel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ColumnModel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ColumnModel.Config Conversion to ColumnModel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColumnModel(ColumnModel.Config config)
        {
            return new ColumnModel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LazyObservable.Config 
        { 
			/*  Implicit ColumnModel.Config Conversion to ColumnModel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ColumnModel.Builder(ColumnModel.Config config)
			{
				return new ColumnModel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool defaultSortable = true;

			/// <summary>
			/// Default sortable of columns which have no sortable specified (defaults to false). This property shall preferably be configured through the defaults config property.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool DefaultSortable 
			{ 
				get
				{
					return this.defaultSortable;
				}
				set
				{
					this.defaultSortable = value;
				}
			}

			private int defaultWidth = 100;

			/// <summary>
			/// The width of columns which have no width specified (defaults to 100). This property shall preferably be configured through the defaults config property.
			/// </summary>
			[DefaultValue(100)]
			public virtual int DefaultWidth 
			{ 
				get
				{
					return this.defaultWidth;
				}
				set
				{
					this.defaultWidth = value;
				}
			}
        
			private ParameterCollection defaults = null;

			/// <summary>
			/// Object literal which will be used to apply Ext.grid.Column configuration options to all columns. Configuration options specified with individual column configs will supersede these defaults.
			/// </summary>
			public ParameterCollection Defaults
			{
				get
				{
					if (this.defaults == null)
					{
						this.defaults = new ParameterCollection();
					}
			
					return this.defaults;
				}
			}
			        
			private ColumnCollection columns = null;

			/// <summary>
			/// The columns to use when rendering the grid (required).
			/// </summary>
			public ColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new ColumnCollection();
					}
			
					return this.columns;
				}
			}
			        
			private ColumnListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ColumnListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ColumnListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ColumnDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public ColumnDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ColumnDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}