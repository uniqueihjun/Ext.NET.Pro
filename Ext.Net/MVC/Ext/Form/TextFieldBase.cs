/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Ext.Net.Utilities;
using Ext.Net.MVC;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class TextFieldBase
    {
        protected override void SetModelValue(object value)
        {
            this.Text = value != null ? value.ToString() : "";
        }

        protected override void OnMetadataProcess(ModelMetadata meta, string name, ViewDataDictionary viewData, ControllerContext context)
        {
            base.OnMetadataProcess(meta, name, viewData, context);

            if (meta.IsRequired)
            {
                this.AllowBlank = false;
            }

            if (this.EmptyText.IsEmpty() && meta.Watermark.IsNotEmpty())
            {
                this.EmptyText = meta.Watermark;
            }

            string type = meta.DataTypeName;
            if (type.IsNotEmpty())
            {
                switch (type)
                {
                    case "Date":
                        this.InputType = Ext.Net.InputType.Date;
                        break;
                    case "DateTime":
                        this.InputType = Ext.Net.InputType.DateTime;
                        break;
                    case "EmailAddress":
                        this.InputType = Ext.Net.InputType.Email;
                        this.StandardVtype = ValidationType.Email;
                        break;
                    case "Password":
                        this.InputType = Ext.Net.InputType.Password;
                        break;
                    case "Time":
                        this.InputType = Ext.Net.InputType.Time;
                        break;
                    case "Url":
                        this.InputType = Ext.Net.InputType.Url;
                        this.StandardVtype = ValidationType.Url;
                        break;
                }
            }

            if (meta.AdditionalValues.ContainsKey(AbstractValidationAttribute.KEY))
            {
                ValidationCollection validations = (ValidationCollection)meta.AdditionalValues[AbstractValidationAttribute.KEY];

                AbstractValidation required = validations.FirstOrDefault(v => v is PresenceValidation);
                
                if (required != null)
                {
                    this.AllowBlank = false;

                    if(required.Message.IsNotEmpty())
                    {
                        this.BlankText = required.Message;
                    }
                }

                AbstractValidation email = validations.FirstOrDefault(v => v is EmailValidation);
                
                if (email != null)
                {
                    this.StandardVtype = ValidationType.Email;

                    if (email.Message.IsNotEmpty())
                    {
                        this.VtypeText = email.Message;
                    }
                }

                LengthValidation length = validations.FirstOrDefault(v => v is LengthValidation) as LengthValidation;
                
                if (length != null)
                {
                    if (length.Max != int.MaxValue)
                    {
                        this.MaxLength = length.Max;
                    }

                    if (length.Min != int.MinValue)
                    {
                        this.MinLength = length.Min;
                    }

                    if (length.Message.IsNotEmpty())
                    {
                        this.MaxLengthText = length.Message;
                        this.MinLengthText = length.Message;
                    }
                }

                FormatValidation format = validations.FirstOrDefault(v => v is FormatValidation) as FormatValidation;

                if (format != null)
                {
                    this.Regex = format.Matcher;

                    if (format.Message.IsNotEmpty())
                    {
                        this.RegexText = format.Message;
                    }
                }
            }
        }

        protected override void SetModelValidationRule(ModelClientValidationRule rule)
        {
            base.SetModelValidationRule(rule);

            switch (rule.ValidationType)
            {
                case "required":
                    this.AllowBlank = false;
                    this.BlankText = rule.ErrorMessage;
                    break;
                case "regex":
                    if (rule.ValidationParameters.ContainsKey("pattern"))
                    {
                        this.Regex = rule.ValidationParameters["pattern"].ToString();
                        this.RegexText = rule.ErrorMessage;
                    }

                    break;
                case "equalto":
                    if (rule.ValidationParameters.ContainsKey("other"))
                    {
                        this.StandardVtype = ValidationType.Password;
                        this.VtypeText = rule.ErrorMessage;

                        string field = rule.ValidationParameters["other"].ToString();
                    
                        if (field.StartsWith("*."))
                        {
                            field = field.Substring(2);
                        }
                        
                        this.CustomConfig.Add(new ConfigItem("initialPassField", field, ParameterMode.Value));
                    }
                    break;
                case "length":
                    if (rule.ValidationParameters.ContainsKey("max"))
                    {
                        this.MaxLength = (int)Convert.ChangeType(rule.ValidationParameters["max"], typeof(int));
                        this.MaxLengthText = rule.ErrorMessage;
                    }

                    if (rule.ValidationParameters.ContainsKey("min"))
                    {
                        this.MinLength = (int)Convert.ChangeType(rule.ValidationParameters["min"], typeof(int));
                        this.MinLengthText = rule.ErrorMessage;
                    }

                    break;
            }
        }
    }
}