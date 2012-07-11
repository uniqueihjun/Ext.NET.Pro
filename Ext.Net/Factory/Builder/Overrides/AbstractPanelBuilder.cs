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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractPanel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractPanel"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractPanel, TBuilder> : AbstractContainer.Builder<TAbstractPanel, TBuilder>
            where TAbstractPanel : AbstractPanel
            where TBuilder : Builder<TAbstractPanel, TBuilder>
        {
            //public virtual ToolbarCollection<TPanelBase, TBuilder> TopBar()
            //{
            //    return new ToolbarCollection<TPanelBase, TBuilder>(this.ToControl(), this as TBuilder);
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder Buttons(Action<ButtonsCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new ButtonsCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder ToolsBuilder(Action<ToolsCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new ToolsCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder TopBarBuilder(Action<TBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new TBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder BottomBarBuilder(Action<BBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new BBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder FooterBarBuilder(Action<FBarCollectionBuilder<TAbstractPanel, TBuilder>> action)
            {
                action(new FBarCollectionBuilder<TAbstractPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }        
    }
}