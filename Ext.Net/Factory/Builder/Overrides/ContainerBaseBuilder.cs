/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class ContainerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TContainerBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TContainerBase, TBuilder> : BoxComponent.Builder<TContainerBase, TBuilder>
            where TContainerBase : ContainerBase
            where TBuilder : Builder<TContainerBase, TBuilder>
        {
            //public virtual ItemsBuilder<TContainerBase, TBuilder> Items()
            //{
            //    return new ItemsBuilder<TContainerBase, TBuilder>(this.ToControl(), this as TBuilder);
            //}

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(Action<ItemsBuilder<TContainerBase, TBuilder>> action)
            {
                action(new ItemsBuilder<TContainerBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }
    }
}