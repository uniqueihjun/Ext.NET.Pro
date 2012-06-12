/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public abstract partial class PanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPanelBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TPanelBase, TBuilder> : ContainerBase.Builder<TPanelBase, TBuilder>
            where TPanelBase : PanelBase
            where TBuilder : Builder<TPanelBase, TBuilder>
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
            public virtual TBuilder Buttons(Action<ButtonsCollectionBuilder<TPanelBase, TBuilder>> action)
            {
                action(new ButtonsCollectionBuilder<TPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder Tools(Action<ToolsCollectionBuilder<TPanelBase, TBuilder>> action)
            {
                action(new ToolsCollectionBuilder<TPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder TopBar(Action<TBarCollectionBuilder<TPanelBase, TBuilder>> action)
            {
                action(new TBarCollectionBuilder<TPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder BottomBar(Action<BBarCollectionBuilder<TPanelBase, TBuilder>> action)
            {
                action(new BBarCollectionBuilder<TPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder FooterBar(Action<FBarCollectionBuilder<TPanelBase, TBuilder>> action)
            {
                action(new FBarCollectionBuilder<TPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }        
    }
}