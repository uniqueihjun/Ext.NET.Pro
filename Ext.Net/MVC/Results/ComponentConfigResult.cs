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
using Ext.Net.Utilities;

namespace Ext.Net.MVC
{
    public class ComponentConfigResult : ActionResult
    {
        private AbstractComponent component;
        private IEnumerable<AbstractComponent> components;
        private object model;
        private string viewName;
        private ViewDataDictionary viewData;
        private TempDataDictionary tempData;

        public ComponentConfigResult()
        {
        }

        public ComponentConfigResult(AbstractComponent component)
        {
            this.component = component;
        }

        public ComponentConfigResult(IEnumerable<AbstractComponent> components)
        {
            this.components = components;
        }

        public ComponentConfigResult(
            string viewName = null,
            ViewDataDictionary viewData = null,
            object model = null,
            TempDataDictionary tempData = null)
        {
            this.model = model;
            this.viewName = viewName;
            this.viewData = viewData;
            this.tempData = tempData;
        }
        
        public override void ExecuteResult(ControllerContext context)
        {
            if(this.component != null)
            {
                context.HttpContext.Response.Write(ComponentLoader.ToConfig(this.component));
            }
            else if (this.components != null)
            {
                context.HttpContext.Response.Write(ComponentLoader.ToConfig(this.components));
            }
            else
            {
                PartialViewResult result = new PartialViewResult();
                result.RenderMode = RenderMode.AddTo;
                result.Config = true;

                if (this.viewName.IsNotEmpty())
                {
                    result.ViewName = this.viewName;
                }

                if (this.model != null)
                {
                    result.Model = this.model;
                }

                if (this.viewData != null)
                {
                    result.ViewData = this.viewData;
                }

                if (this.tempData != null)
                {
                    result.TempData = this.tempData;
                }

                result.ExecuteResult(context);

                context.HttpContext.Response.Write(result.Output);
            }
        }
    }
}