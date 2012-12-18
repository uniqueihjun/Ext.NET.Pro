/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.Net
{
    public abstract partial class AbstractDataView
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractDataView, TBuilder> : ComponentBase.Builder<TAbstractDataView, TBuilder>
            where TAbstractDataView : AbstractDataView
            where TBuilder : Builder<TAbstractDataView, TBuilder>
        {
            public virtual TBuilder Store(Store store)
            {
                this.ToComponent().Store.Add(store);
                return this as TBuilder;
            }

            public virtual TBuilder Tpl(Func<object, object> html)
            {
                object result = html(null);
                this.ToComponent().Tpl = new XTemplate { Html = result.ToString() };

                return this as TBuilder;
            }

            public virtual TBuilder ItemTpl(Func<object, object> html)
            {
                object result = html(null);
                this.ToComponent().ItemTpl = new XTemplate { Html = result.ToString() };

                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="handler"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder PrepareData(string handler)
            {
                if (JFunction.IsFunctionName(handler))
                {
                    this.ToComponent().PrepareData.Fn = handler;
                }
                else
                {
                    this.ToComponent().PrepareData.Handler = handler;
                }

                return this as TBuilder;
            }
        }
    }
}