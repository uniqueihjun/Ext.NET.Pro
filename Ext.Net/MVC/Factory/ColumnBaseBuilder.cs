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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class ColumnBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TColumnBase, TBuilder> : ComponentBase.Builder<TColumnBase, TBuilder>
            where TColumnBase : ColumnBase
            where TBuilder : Builder<TColumnBase, TBuilder>
        {
            /// <summary>
            /// Required. The name of the field in the grid's Ext.data.Store's Ext.data.Model definition from which to draw the column's value.
            /// </summary>
            public virtual TBuilder DataIndex<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().DataIndex = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }

            /// <summary>
            /// Required. The name of the field in the grid's Ext.data.Store's Ext.data.Model definition from which to draw the column's value.
            /// </summary>
            public virtual TBuilder DataIndex<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().DataIndex = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }
        }        
    }
}