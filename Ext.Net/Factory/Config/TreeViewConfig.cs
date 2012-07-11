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
    public partial class TreeView
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TreeView(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TreeView.Config Conversion to TreeView
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TreeView(TreeView.Config config)
        {
            return new TreeView(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TableView.Config 
        { 
			/*  Implicit TreeView.Config Conversion to TreeView.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TreeView.Builder(TreeView.Config config)
			{
				return new TreeView.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool animate = true;

			/// <summary>
			/// True to enable animated expand/collapse (defaults to the value of Ext.enableFx)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Animate 
			{ 
				get
				{
					return this.animate;
				}
				set
				{
					this.animate = value;
				}
			}

			private bool rootVisible = true;

			/// <summary>
			/// False to hide the root node (defaults to true)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RootVisible 
			{ 
				get
				{
					return this.rootVisible;
				}
				set
				{
					this.rootVisible = value;
				}
			}
        
			private TableViewListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public TableViewListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new TableViewListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private TableViewDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public TableViewDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new TableViewDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}