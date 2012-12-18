/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class GridFilter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGridFilter, TBuilder> : BaseItem.Builder<TGridFilter, TBuilder>
            where TGridFilter : GridFilter
            where TBuilder : Builder<TGridFilter, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DataIndex<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().DataIndex = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DataIndex<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().DataIndex = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }
        }
    }
}