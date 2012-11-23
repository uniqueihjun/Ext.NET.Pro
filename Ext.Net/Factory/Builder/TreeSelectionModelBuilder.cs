/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TreeSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTreeSelectionModel, TBuilder> : RowSelectionModel.Builder<TTreeSelectionModel, TBuilder>
            where TTreeSelectionModel : TreeSelectionModel
            where TBuilder : Builder<TTreeSelectionModel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTreeSelectionModel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Prune records when they are removed from the store from the selection.
			/// </summary>
            public virtual TBuilder PruneRemoved(bool pruneRemoved)
            {
                this.ToComponent().PruneRemoved = pruneRemoved;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreeSelectionModel.Builder<TreeSelectionModel, TreeSelectionModel.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeSelectionModel(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.TreeSelectionModel(new TreeSelectionModel { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TreeSelectionModel(new TreeSelectionModel());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder TreeSelectionModel(TreeSelectionModel component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TreeSelectionModel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeSelectionModel.Builder TreeSelectionModel(TreeSelectionModel.Config config)
        {
#if MVC
			return new TreeSelectionModel.Builder(new TreeSelectionModel(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TreeSelectionModel.Builder(new TreeSelectionModel(config));
#endif			
        }
    }
}