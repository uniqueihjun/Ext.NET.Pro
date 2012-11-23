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
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Ext.Net
{
    public class GenericModelFieldBuilder<T> where T : class
    {
        private HtmlHelper helper;
        private ModelFieldCollection fields = new ModelFieldCollection();

        public GenericModelFieldBuilder(HtmlHelper helper)
        {
            this.helper = helper;
        }

        public ModelFieldCollection Fields
        {
            get
            {
                return this.fields;
            }
        }

        public ModelField.Builder For<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var field = Ext.Net.Store.CreateModelFieldFromMeta(ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>()), null, null, this.helper.ViewContext.Controller != null ? this.helper.ViewContext.Controller.ControllerContext : null);
            this.fields.Add(field);

            var builder = new ModelField.Builder(field);
            return builder;
        }
    }

    public partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Model.Builder<Model, Model.Builder>
        {
            public Model.Builder FieldFor<T>(Action<GenericModelFieldBuilder<T>> fields) where T : class
            {
                var fieldsBuilder = new GenericModelFieldBuilder<T>(Ext.Net.X.Builder.HtmlHelper);
                fields(fieldsBuilder);

                this.ToComponent().Fields.AddRange(fieldsBuilder.Fields);

                return this as Model.Builder;
            }

            public Model.Builder FieldFor<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                var viewContext = Ext.Net.X.Builder.HtmlHelper.ViewContext;
                var field = Ext.Net.Store.CreateModelFieldFromMeta(ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>()), null, null, viewContext.Controller != null ? viewContext.Controller.ControllerContext : null);
                this.ToComponent().Fields.Add(field);

                return this as Model.Builder;
            }

            public Model.Builder FieldFor<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                var viewContext = Ext.Net.X.Builder.HtmlHelper.ViewContext;
                var field = Ext.Net.Store.CreateModelFieldFromMeta(ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<T>()), null, null, viewContext.Controller != null ? viewContext.Controller.ControllerContext : null);
                this.ToComponent().Fields.Add(field);

                return this as Model.Builder;
            }

            public Model.Builder IDProperty<T, TProperty>(IEnumerable<T> model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().IDProperty = ExpressionHelper.GetExpressionText(expression);
                return this as Model.Builder;
            }

            public Model.Builder IDProperty<T, TProperty>(T model, Expression<Func<T, TProperty>> expression) where T : class
            {
                this.ToComponent().IDProperty = ExpressionHelper.GetExpressionText(expression);
                return this as Model.Builder;
            }
        }
    }
}