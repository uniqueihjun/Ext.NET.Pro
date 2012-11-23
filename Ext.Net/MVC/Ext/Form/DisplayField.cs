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
    public partial class DisplayField
    {
        protected override void OnMetadataProcess(ModelMetadata meta, string name, ViewDataDictionary viewData, ControllerContext context)
        {
            base.OnMetadataProcess(meta, name, viewData, context);

            if (this.EmptyText.IsEmpty() && meta.NullDisplayText.IsNotEmpty())
            {
                this.EmptyText = meta.NullDisplayText;
            }

            if (meta.DisplayFormatString.IsNotEmpty() && (this.FormatControlForValue.IsEmpty() || this.FormatControlForValue == meta.EditFormatString))
            {
                this.FormatControlForValue = meta.DisplayFormatString;
            }
        }
        protected override void SetModelValidationRule(ModelClientValidationRule rule)
        {
        }

        protected override void SetModelValue(object value)
        {
            if (value != null)
            {
                this.Text = value.ToString();
            }
        }
    }
}