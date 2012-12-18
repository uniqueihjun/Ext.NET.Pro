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
using System.Globalization;
using Ext.Net.Utilities;
using Ext.Net.MVC;

namespace Ext.Net
{
    public partial class BuilderFactory
    {
        public TextField.Builder TextFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TextField, TextField.Builder>(expression, setId, convert, format);
        }

        public ComboBox.Builder ComboBoxFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<ComboBox, ComboBox.Builder>(expression, setId, convert, format);
        }

        public SelectBox.Builder SelectBoxFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<SelectBox, SelectBox.Builder>(expression, setId, convert, format);
        }

        public Checkbox.Builder CheckboxFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Checkbox, Checkbox.Builder>(expression, setId, convert, format);
        }

        public DateField.Builder DateFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DateField, DateField.Builder>(expression, setId, convert, format);
        }

        public DisplayField.Builder DisplayFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DisplayField, DisplayField.Builder>(expression, setId, convert, format);
        }

        public DropDownField.Builder DropDownFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DropDownField, DropDownField.Builder>(expression, setId, convert, format);
        }

        public Hidden.Builder HiddenFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Hidden, Hidden.Builder>(expression, setId, convert, format);
        }

        public HtmlEditor.Builder HtmlEditorFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<HtmlEditor, HtmlEditor.Builder>(expression, setId, convert, format);
        }

        public MultiCombo.Builder MultiComboFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<MultiCombo, MultiCombo.Builder>(expression, setId, convert, format);
        }

        public MultiSelect.Builder MultiSelectFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<MultiSelect, MultiSelect.Builder>(expression, setId, convert, format);
        }

        public NumberField.Builder NumberFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<NumberField, NumberField.Builder>(expression, setId, convert, format);
        }

        public Radio.Builder RadioFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Radio, Radio.Builder>(expression, setId, convert, format);
        }

        public SpinnerField.Builder SpinnerFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<SpinnerField, SpinnerField.Builder>(expression, setId, convert, format);
        }

        public TextArea.Builder TextAreaFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TextArea, TextArea.Builder>(expression, setId, convert, format);
        }

        public TimeField.Builder TimeFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TimeField, TimeField.Builder>(expression, setId, convert, format);
        }

        public TriggerField.Builder TriggerFieldFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TriggerField, TriggerField.Builder>(expression, setId, convert, format);
        }

        public Slider.Builder SliderFor(string expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Slider, Slider.Builder>(expression, setId, convert, format);
        }

        private TBuilder InitFieldForBuilder<TField, TBuilder>(string expression, bool setId, Func<object, object> convert = null, string format = null)
            where TField : Field
            where TBuilder : Field.Builder<TField, TBuilder>, new()
        {
            TBuilder builder = new TBuilder();
            var cmp = builder.ToComponent();

            cmp.ViewContext = this.HtmlHelper.ViewContext;
            cmp.IDFromControlFor = setId;
            cmp.ConvertControlForValue = convert;
            cmp.FormatControlForValue = format;

            builder.ControlFor(expression);
            cmp.SetControlFor(ModelMetadata.FromStringExpression(expression, this.HtmlHelper.ViewData));
            return builder;
        }
    }

    public partial class BuilderFactory<TModel> : BuilderFactory
    {
        public TextField.Builder TextFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TextField, TextField.Builder, TProperty>(expression, setId, convert, format);
        }

        public ComboBox.Builder ComboBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<ComboBox, ComboBox.Builder, TProperty>(expression, setId, convert, format);
        }

        public SelectBox.Builder SelectBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<SelectBox, SelectBox.Builder, TProperty>(expression, setId, convert, format);
        }

        public Checkbox.Builder CheckboxFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Checkbox, Checkbox.Builder, TProperty>(expression, setId, convert, format);
        }

        public DateField.Builder DateFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DateField, DateField.Builder, TProperty>(expression, setId, convert, format);
        }

        public DisplayField.Builder DisplayFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DisplayField, DisplayField.Builder, TProperty>(expression, setId, convert, format);
        }

        public DropDownField.Builder DropDownFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<DropDownField, DropDownField.Builder, TProperty>(expression, setId, convert, format);
        }

        public Hidden.Builder HiddenFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Hidden, Hidden.Builder, TProperty>(expression, setId, convert, format);
        }

        public HtmlEditor.Builder HtmlEditorFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<HtmlEditor, HtmlEditor.Builder, TProperty>(expression, setId, convert, format);
        }

        public MultiCombo.Builder MultiComboFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<MultiCombo, MultiCombo.Builder, TProperty>(expression, setId, convert, format);
        }

        public MultiSelect.Builder MultiSelectFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<MultiSelect, MultiSelect.Builder, TProperty>(expression, setId, convert, format);
        }

        public NumberField.Builder NumberFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<NumberField, NumberField.Builder, TProperty>(expression, setId, convert, format);
        }

        public Radio.Builder RadioFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Radio, Radio.Builder, TProperty>(expression, setId, convert, format);
        }

        public SpinnerField.Builder SpinnerFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<SpinnerField, SpinnerField.Builder, TProperty>(expression, setId, convert, format);
        }

        public TextArea.Builder TextAreaFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TextArea, TextArea.Builder, TProperty>(expression, setId, convert, format);
        }

        public TimeField.Builder TimeFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TimeField, TimeField.Builder, TProperty>(expression, setId, convert, format);
        }

        public TriggerField.Builder TriggerFieldFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<TriggerField, TriggerField.Builder, TProperty>(expression, setId, convert, format);
        }

        public Slider.Builder SliderFor<TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return this.InitFieldForBuilder<Slider, Slider.Builder, TProperty>(expression, setId, convert, format);
        }

        private TBuilder InitFieldForBuilder<TField, TBuilder, TProperty>(Expression<Func<TModel, TProperty>> expression, bool setId, Func<object, object> convert = null, string format = null)
            where TField : Field
            where TBuilder : Field.Builder<TField, TBuilder>, new()
        {
            TBuilder builder = new TBuilder();
            var cmp = builder.ToComponent();
            cmp.ViewContext = this.HtmlHelper.ViewContext;
            cmp.IDFromControlFor = setId;
            cmp.ConvertControlForValue = convert;
            cmp.FormatControlForValue = format;

            builder.ControlFor(ExpressionHelper.GetExpressionText(expression));
            cmp.SetControlFor(ModelMetadata.FromLambdaExpression(expression, this.HtmlHelper.ViewData));
            return builder;
        }
    }
}