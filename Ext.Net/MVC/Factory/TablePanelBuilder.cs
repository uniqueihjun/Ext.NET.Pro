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
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Ext.Net.MVC;
using Ext.Net.Utilities;

namespace Ext.Net
{
    public class GenericColumnBuilder<T> where T : class
    {
        private HtmlHelper helper;
        private ColumnCollection columns = new ColumnCollection();

        public GenericColumnBuilder(HtmlHelper helper)
        {
            this.helper = helper;
        }

        public ColumnCollection Columns
        {
            get
            {
                return this.columns;
            }
        }

        public ColumnBase For<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var meta = ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>());
            var column = TablePanel.CreateColumn(meta, this.helper.ViewContext);

            this.columns.Add(column);

            return column;
        }
    }

    public partial class TablePanel
    {
        internal static ColumnBase CreateColumn(ModelMetadata meta, ViewContext viewContext)
        {
            if (meta == null)
            {
                throw new ArgumentNullException("meta", "ModelMetadata is null");
            }
            var column = meta.AdditionalValues.ContainsKey(ColumnBaseAttribute.KEY) ? (ColumnBase)meta.AdditionalValues[ColumnBaseAttribute.KEY] : null;

            if (column == null)
            {
                column = new Column();
                column.DataIndex = meta.PropertyName;
                if (meta.AdditionalValues.ContainsKey(ModelFieldAttribute.KEY))
                {
                    string name = ((ModelFieldAttribute)meta.AdditionalValues[ModelFieldAttribute.KEY]).Name;
                    if (name.IsNotEmpty())
                    {
                        column.DataIndex = name;
                    }
                }

                column.Text = Regex.Replace(meta.PropertyName, "([a-z])([A-Z])", "$1 $2");
            }

            if (viewContext != null)
            {
                column.ViewContext = viewContext;
            }

            return column;
        }

        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTablePanel, TBuilder> : AbstractPanel.Builder<TTablePanel, TBuilder>
            where TTablePanel : TablePanel
            where TBuilder : Builder<TTablePanel, TBuilder>
        {
            public TBuilder ColumnFor<T>(Action<GenericColumnBuilder<T>> columns) where T : class
            {
                var _columns = new GenericColumnBuilder<T>(Ext.Net.X.Builder.HtmlHelper);
                columns(_columns);

                this.ToComponent().ColumnModel.Columns.AddRange(_columns.Columns);

                return this as TBuilder;
            }

            public TBuilder ColumnFor<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                var viewContext = Ext.Net.X.Builder.HtmlHelper.ViewContext;
                var column = TablePanel.CreateColumn(ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>()), Ext.Net.X.Builder.HtmlHelper.ViewContext);
                this.ToComponent().ColumnModel.Columns.Add(column);

                return this as TBuilder;
            }

            public TBuilder ColumnFor<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                var viewContext = Ext.Net.X.Builder.HtmlHelper.ViewContext;
                var column = TablePanel.CreateColumn(ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>()), Ext.Net.X.Builder.HtmlHelper.ViewContext);
                this.ToComponent().ColumnModel.Columns.Add(column);

                return this as TBuilder;
            }
        }
    }
}