/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class MultiSelectBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TMultiSelectBase, TBuilder> : Field.Builder<TMultiSelectBase, TBuilder>
            where TMultiSelectBase : MultiSelectBase
            where TBuilder : Builder<TMultiSelectBase, TBuilder>
        {
            public virtual TBuilder Store(Store store)
            {
                this.ToComponent().Store.Add(store);
                return this as TBuilder;
            }

            public virtual TBuilder Items(IEnumerable<ListItem> items)
            {
                this.ToComponent().Items.AddRange(items);
                return this as TBuilder;
            }

            public virtual TBuilder Items(ListItem item)
            {
                this.ToComponent().Items.Add(item);
                return this as TBuilder;
            }

            public virtual TBuilder Items(object items)
            {
                this.ToComponent().Items.Add(items);
                return this as TBuilder;
            }
        }
    }
}