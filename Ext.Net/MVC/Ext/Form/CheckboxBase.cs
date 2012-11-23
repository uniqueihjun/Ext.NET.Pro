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
    public partial class CheckboxBase
    {
        protected override void OnMetadataProcess(ModelMetadata meta, string name, ViewDataDictionary viewData, ControllerContext context)
        {
            base.OnMetadataProcess(meta, name, viewData, context);

            if (meta.AdditionalValues.ContainsKey(AbstractValidationAttribute.KEY))
            {
                ValidationCollection validations = (ValidationCollection)meta.AdditionalValues[AbstractValidationAttribute.KEY];

                AbstractValidation required = validations.FirstOrDefault(v => v is PresenceValidation);
                
                if (required != null)
                {
                    this.UncheckedValue = "false";
                }
            }
        }

        protected override void SetModelValue(object value)
        {            
            if (value != null)
            {
                this.InputValue = "true";                

                if (value is bool)
                {
                    this.Checked = (bool)Convert.ChangeType(value, typeof(bool));
                }
                else
                {
                    this.Checked = String.Equals(this.Name, value.ToString(), StringComparison.Ordinal);
                }
            }
        }

        protected override void SetModelValidationRule(ModelClientValidationRule rule)
        {
            base.SetModelValidationRule(rule);

            switch (rule.ValidationType)
            {
                case "required":
                    //this.GetErrors.Handler = "return this.getValue() ? [] : [" + JSON.Serialize(rule.ErrorMessage) + "];";
                    this.UncheckedValue = "false";
                    break;
            }
        }
    }
}