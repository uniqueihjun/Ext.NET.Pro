/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class TreeDragZone
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTreeDragZone, TBuilder> : DragZone.Builder<TTreeDragZone, TBuilder>
            where TTreeDragZone : TreeDragZone
            where TBuilder : Builder<TTreeDragZone, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTreeDragZone component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreeDragZone.Builder<TreeDragZone, TreeDragZone.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreeDragZone()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeDragZone component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreeDragZone.Config config) : base(new TreeDragZone(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreeDragZone component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreeDragZone(this);
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
        public TreeDragZone.Builder TreeDragZone()
        {
#if MVC
			return this.TreeDragZone(new TreeDragZone { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TreeDragZone(new TreeDragZone());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder TreeDragZone(TreeDragZone component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TreeDragZone.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreeDragZone.Builder TreeDragZone(TreeDragZone.Config config)
        {
#if MVC
			return new TreeDragZone.Builder(new TreeDragZone(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TreeDragZone.Builder(new TreeDragZone(config));
#endif			
        }
    }
}