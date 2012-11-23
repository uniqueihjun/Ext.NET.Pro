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
using System.Collections;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class SliderBase
    {
        protected override void SetModelValue(object value)
        {
            if (value != null)
            {
                if (this.Single)
                {
                    this.Number = Convert.ToDouble(value);
                }
                else
                {
                    if (value is IEnumerable)
                    {
                        this.Numbers = ((IEnumerable)value).Cast<object>().Select(n => Convert.ToDouble(n)).ToArray();
                    }
                    else
                    {
                        this.Numbers = new double[] { Convert.ToDouble(value) };
                    }
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
                        this.MaxValue = (double)Convert.ChangeType(rule.ValidationParameters["max"], typeof(double));
                    }

                    if (rule.ValidationParameters.ContainsKey("min"))
                    {
                        this.MinValue = (double)Convert.ChangeType(rule.ValidationParameters["min"], typeof(double));
                    }
                    break;
            }
        }
    }
}