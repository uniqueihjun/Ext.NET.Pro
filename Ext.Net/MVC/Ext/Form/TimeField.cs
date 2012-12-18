/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class TimeField
    {
        protected override void SetModelValue(object value)
        {
            if (value != null)
            {
                if (value is string)
                {
                    this.SelectedTime = TimeSpan.ParseExact(value.ToString(), this.Format, System.Globalization.CultureInfo.CurrentUICulture);
                }
                else
                {
                    this.SelectedTime = (TimeSpan)Convert.ChangeType(value, typeof(TimeSpan));
                }
            }
        }

        protected override void SetModelValidationRule(ModelClientValidationRule rule)
        {
            base.SetModelValidationRule(rule);

            switch (rule.ValidationType)
            {
                case "range":
                    if (rule.ValidationParameters.ContainsKey("max"))
                    {
                        this.MaxTime = (TimeSpan)Convert.ChangeType(rule.ValidationParameters["max"], typeof(TimeSpan));
                        this.MaxText = rule.ErrorMessage;
                    }

                    if (rule.ValidationParameters.ContainsKey("min"))
                    {
                        this.MinTime = (TimeSpan)Convert.ChangeType(rule.ValidationParameters["min"], typeof(TimeSpan));
                        this.MinText = rule.ErrorMessage;
                    }
                    break;
            }
        }
    }
}