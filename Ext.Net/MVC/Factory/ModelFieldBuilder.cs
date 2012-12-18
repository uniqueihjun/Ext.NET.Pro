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
    public partial class ModelField
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TModelField, TBuilder> : BaseItem.Builder<TModelField, TBuilder>
            where TModelField : ModelField
            where TBuilder : Builder<TModelField, TBuilder>
        {
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Name<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().Name = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder Name<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().Name = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ServerMapping<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().ServerMapping = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder ServerMapping<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().ServerMapping = ExpressionHelper.GetExpressionText(expression);
                return this as TBuilder;
            }
        }
    }
    
}