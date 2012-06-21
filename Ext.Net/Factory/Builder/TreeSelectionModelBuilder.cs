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
    public partial class TreeSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : RowSelectionModel.Builder<TreeSelectionModel, TreeSelectionModel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeSelectionModel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeSelectionModel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeSelectionModel.Config config) : base(new TreeSelectionModel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeSelectionModel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Prune records when they are removed from the store from the selection.
			/// </summary>
            public virtual TreeSelectionModel.Builder PruneRemoved(bool pruneRemoved)
            {
                this.ToComponent().PruneRemoved = pruneRemoved;
                return this as TreeSelectionModel.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeSelectionModel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder TreeSelectionModel()
        {
            return this.TreeSelectionModel(new TreeSelectionModel());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder TreeSelectionModel(TreeSelectionModel component)
        {
            return new TreeSelectionModel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder TreeSelectionModel(TreeSelectionModel.Config config)
        {
            return new TreeSelectionModel.Builder(new TreeSelectionModel(config));
        }
    }
}