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
    public partial class TreeColumn
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ColumnBase.Builder<TreeColumn, TreeColumn.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeColumn()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeColumn component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeColumn.Config config) : base(new TreeColumn(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeColumn component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeColumn.Builder</returns>
            public virtual TreeColumn.Builder Listeners(Action<ColumnListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TreeColumn.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreeColumn.Builder</returns>
            public virtual TreeColumn.Builder DirectEvents(Action<ColumnDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TreeColumn.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeColumn.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeColumn(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreeColumn.Builder TreeColumn()
        {
            return this.TreeColumn(new TreeColumn());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeColumn.Builder TreeColumn(TreeColumn component)
        {
            return new TreeColumn.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeColumn.Builder TreeColumn(TreeColumn.Config config)
        {
            return new TreeColumn.Builder(new TreeColumn(config));
        }
    }
}