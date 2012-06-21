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
    public partial class TreeView
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TableView.Builder<TreeView, TreeView.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeView()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeView component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeView.Config config) : base(new TreeView(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeView component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to enable animated expand/collapse (defaults to the value of Ext.enableFx)
			/// </summary>
            public virtual TreeView.Builder Animate(bool animate)
            {
                this.ToComponent().Animate = animate;
                return this as TreeView.Builder;
            }
             
 			/// <summary>
			/// False to hide the root node (defaults to true)
			/// </summary>
            public virtual TreeView.Builder RootVisible(bool rootVisible)
            {
                this.ToComponent().RootVisible = rootVisible;
                return this as TreeView.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeView.Builder</returns>
            public virtual TreeView.Builder Listeners(Action<TableViewListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TreeView.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeView.Builder</returns>
            public virtual TreeView.Builder DirectEvents(Action<TableViewDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TreeView.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeView.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeView(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreeView.Builder TreeView()
        {
            return this.TreeView(new TreeView());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeView.Builder TreeView(TreeView component)
        {
            return new TreeView.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeView.Builder TreeView(TreeView.Config config)
        {
            return new TreeView.Builder(new TreeView(config));
        }
    }
}