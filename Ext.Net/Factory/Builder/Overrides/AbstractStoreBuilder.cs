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
    public abstract partial class AbstractStore
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractStore, TBuilder> : Observable.Builder<TAbstractStore, TBuilder>
            where TAbstractStore : AbstractStore
            where TBuilder : Builder<TAbstractStore, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="model"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Model(Model model)
            {
                this.ToComponent().Model.Add(model);
                return this as TBuilder;
            }

            /// <summary>
            /// The Proxy to use for this Store.
            /// </summary>
            /// <param name="proxy">proxy</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Proxy(AbstractProxy proxy)
            {
                this.ToComponent().Proxy.Add(proxy);
                return this as TBuilder;
            }

            /// <summary>
            /// The Proxy to use for reload or sync actions when Memory proxy is used for initial data
            /// </summary>
            /// <param name="proxy">proxy</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder ServerProxy(AbstractProxy proxy)
            {
                this.ToComponent().ServerProxy.Add(proxy);
                return this as TBuilder;
            }

            /// <summary>
            /// The collection of Sorters currently applied to this Store
            /// </summary>
            /// <param name="sorter"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Sorters(DataSorter sorter)
            {
                this.ToComponent().Sorters.Add(sorter);
                return this as TBuilder;
            }

            /// <summary>
            /// The collection of Sorters currently applied to this Store
            /// </summary>
            /// <param name="property"></param>
            /// <param name="direction"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Sorters(string property, SortDirection direction)
            {
                this.ToComponent().Sorters.Add(new DataSorter { Property = property, Direction = direction });
                return this as TBuilder;
            }

            /// <summary>
            /// An object containing properties which are to be sent as parameters on auto load HTTP request.
            /// </summary>
            /// <param name="parameters"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder AutoLoadParams(object parameters)
            {
                if (parameters != null)
                {
                    this.ToComponent().AutoLoadParams.Add(parameters);
                }
                return this as TBuilder;
            }

            /// <summary>
            /// An object containing properties which are to be sent as parameters on any HTTP request.
            /// </summary>
            /// <param name="parameters"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Parameters(object parameters)
            {
                if (parameters != null)
                {
                    this.ToComponent().Parameters.Add(parameters);
                }
                return this as TBuilder;
            }

            /// <summary>
            /// An object containing properties which are to be sent as parameters on sync request.
            /// </summary>
            /// <param name="parameters"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder SyncParameters(object parameters)
            {
                if (parameters != null)
                {
                    this.ToComponent().SyncParameters.Add(parameters);
                }
                return this as TBuilder;
            }
        }
    }
}