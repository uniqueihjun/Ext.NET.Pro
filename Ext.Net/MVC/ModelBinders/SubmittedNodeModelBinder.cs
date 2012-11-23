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
using System.Web.Mvc;
using System.Web;
using Newtonsoft.Json.Serialization;
using Ext.Net.Utilities;

namespace Ext.Net.MVC
{
    public class SubmittedNodeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var vpr = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (vpr == null || vpr.AttemptedValue.IsEmpty())
            {
                return null;
            }

            return JSON.Deserialize<SubmittedNode>(vpr.AttemptedValue, new CamelCasePropertyNamesContractResolver());
        }
    }
}