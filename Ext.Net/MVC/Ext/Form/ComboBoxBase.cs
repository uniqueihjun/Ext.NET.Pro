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
    public partial class ComboBoxBase
    {
        protected override void SetModelValue(object value)
        {
            if (value != null)
            {
                if (value != null && value.GetType().IsEnum)
                {
                    this.ItemsFromEnum = value.GetType();
                    this.SelectedItems.Add(new ListItem { Value = Convert.ChangeType(value, ((Enum)value).GetTypeCode()).ToString() });
                }
                else if (value is ListItem)
                {
                    this.SelectedItems.Add((ListItem)value);
                }
                else if (value is IEnumerable<ListItem>)
                {
                    this.SelectedItems.AddRange((IEnumerable<ListItem>)value);
                }
                else
                {
                    this.SelectedItems.Add(new ListItem { Value = JSON.Serialize(value), Mode = ParameterMode.Raw });
                }
            }
        }
    }
}