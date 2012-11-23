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

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class Observable
    {
        protected override void SetModelAdditionalValue(KeyValuePair<string, object> value)
        {
            base.SetModelAdditionalValue(value);
            if (!value.Key.StartsWith("__ext.net."))
            {
                if (value.Value != null && value.Value is string && TokenUtils.IsRawToken(value.Value.ToString()))
                {
                    this.CustomConfig.Add(new ConfigItem(value.Key, TokenUtils.ReplaceRawToken(value.Value.ToString()), ParameterMode.Raw));
                }
                else
                {
                    this.CustomConfig.Add(new ConfigItem(value.Key, JSON.Serialize(value.Value), ParameterMode.Raw));
                }
            }
        }
    }
}