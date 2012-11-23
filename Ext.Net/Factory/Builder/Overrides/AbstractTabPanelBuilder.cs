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

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractTabPanel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractTabPanel"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractTabPanel, TBuilder> : AbstractPanel.Builder<TAbstractTabPanel, TBuilder>
            where TAbstractTabPanel : AbstractTabPanel
            where TBuilder : Builder<TAbstractTabPanel, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder DefaultTabMenuBuilder(Action<DefaultTabMenuCollectionBuilder<TAbstractTabPanel, TBuilder>> action)
            {
                action(new DefaultTabMenuCollectionBuilder<TAbstractTabPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// TabBar collection
            /// </summary>
            [Description("TabBar collection")]
            public virtual TBuilder TabBar(AbstractComponent item)
            {
                this.ToComponent().TabBar.Add(item);
                return this as TBuilder;
            }

            /// <summary>
            /// TabBar collection
            /// </summary>
            [Description("TabBar collection")]
            public virtual TBuilder TabBar(IEnumerable<AbstractComponent> items)
            {
                this.ToComponent().TabBar.AddRange(items);
                return this as TBuilder;
            }

            /// <summary>
            /// TabBar collection
            /// </summary>
            [Description("TabBar collection")]
            public virtual TBuilder TabBar(params AbstractComponent[] items)
            {
                this.ToComponent().TabBar.AddRange(items);
                return this as TBuilder;
            }
        }
    }
}