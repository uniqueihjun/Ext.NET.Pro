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
using System.Web.Mvc;
using System.Linq.Expressions;

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
            public TBuilder SorterFor<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression, SortDirection direction) where T : class
            {
                this.ToComponent().Sorters.Add(new DataSorter { Property = ExpressionHelper.GetExpressionText(expression), Direction = direction });
                return this as TBuilder;
            }

            public TBuilder SorterFor<T, TProperty>(T model, Expression<Func<T, TProperty>> expression, SortDirection direction) where T : class
            {
                this.ToComponent().Sorters.Add(new DataSorter { Property = ExpressionHelper.GetExpressionText(expression), Direction = direction });
                return this as TBuilder;
            }
        }
    }
}