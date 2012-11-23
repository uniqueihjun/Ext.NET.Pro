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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class TabPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TTabPanelBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TTabPanelBase, TBuilder> : PanelBase.Builder<TTabPanelBase, TBuilder>
            where TTabPanelBase : TabPanelBase
            where TBuilder : Builder<TTabPanelBase, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder DefaultTabMenu(Action<DefaultTabMenuCollectionBuilder<TTabPanelBase, TBuilder>> action)
            {
                action(new DefaultTabMenuCollectionBuilder<TTabPanelBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }
    }
}