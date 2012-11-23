/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    public partial class ModelStateStore : Store
    {
        /// <summary>
        /// 
        /// </summary>
        public ModelStateStore()
        {
        }
        
        public override void DataBind()
        {
            var viewData = this.ViewData;

            if (viewData == null)
            {
                return;
            }

            this.Model.Clear();
            this.Model.Add(new Model
            {
                Fields = { 
                    new ModelField("name"),
                    new ModelField("error"),
                    new ModelField("value"){ IsComplex = true }
                }
            });

            List<object> states = new List<object>();
            foreach (var state in viewData.ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    states.Add(new
                    {
                        name = state.Key,
                        error = error.ErrorMessage,
                        value = ModelMetadata.FromStringExpression(state.Key, viewData).Model
                    });
                }
            }

            this.DataSource = states;

            base.DataBind();
        }
    }
}