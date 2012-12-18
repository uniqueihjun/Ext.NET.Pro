/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI;
using System.Web;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractContainer
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAbstractContainer, TBuilder> : ComponentBase.Builder<TAbstractContainer, TBuilder>
            where TAbstractContainer : AbstractContainer
            where TBuilder : Builder<TAbstractContainer, TBuilder>
        {
            /// <summary>
            /// The layout type to be used in this container.
            /// </summary>
            public virtual TBuilder Layout(LayoutType layout)
            {
                this.ToComponent().Layout = layout.ToString();
                return this as TBuilder;
            }

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(Action<ItemsBuilder<TAbstractContainer, TBuilder>> action)
            {
                action(new ItemsBuilder<TAbstractContainer, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(AbstractComponent item)
            {
                this.ToComponent().Items.Add(item);
                return this as TBuilder;
            }

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(IEnumerable<AbstractComponent> items)
            {
                this.ToComponent().Items.AddRange(items);
                return this as TBuilder;
            }

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(params AbstractComponent[] items)
            {
                this.ToComponent().Items.AddRange(items);
                return this as TBuilder;
            }

            public virtual TBuilder Defaults(object parameters)
            {
                this.ToComponent().Defaults.Add(parameters);
                return this as TBuilder;
            }

            /// <summary>
            /// This is a config object containing properties specific to the chosen layout (to be used in conjunction with the layout config value)
            /// </summary>
            /// <param name="action">The action delegate</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder LayoutConfig(LayoutConfig config)
            {
                this.ToComponent().LayoutConfig.Add(config);
                return this as TBuilder;
            }
        }
    }
}