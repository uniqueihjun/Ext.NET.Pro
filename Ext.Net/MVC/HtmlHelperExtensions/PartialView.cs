/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Web.Mvc;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public static class PartialViewExtensions
    {
        /// <summary>
        /// Renders the partial view with the parent's view data
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, null, IDMode.Explicit, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="idMode"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, IDMode idMode)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, null, idMode, null);
        }

        /// <summary>
        /// Renders the partial view with the parent's view data
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, string id)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, null, IDMode.Explicit, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="idMode"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, IDMode idMode, string id)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, null, idMode, id);
        }

        /// <summary>
        /// Renders the partial view with the given view data
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData)
        {
            return htmlHelper.RenderExtPartial(partialViewName, viewData, null, IDMode.Explicit, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="viewData"></param>
        /// <param name="idMode"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData, IDMode idMode)
        {
            return htmlHelper.RenderExtPartial(partialViewName, viewData, null, idMode, null);
        }

        /// <summary>
        /// Renders the partial view with the given view data
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="viewData"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData, string id)
        {
            return htmlHelper.RenderExtPartial(partialViewName, viewData, null, IDMode.Explicit, id);
        }

        /// <summary>
        /// Renders the partial view with an empty view data and the given model
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, object model)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, model, IDMode.Explicit, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="model"></param>
        /// <param name="idMode"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, object model, IDMode idMode)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, model, idMode, null);
        }

        /// <summary>
        /// Renders the partial view with an empty view data and the given model
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, object model, string id)
        {
            return htmlHelper.RenderExtPartial(partialViewName, htmlHelper.ViewData, model, IDMode.Explicit, id);
        }

        /// <summary>
        /// Renders the partial view with a copy of the given view data plus the given model
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="model"></param>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, object model, ViewDataDictionary viewData)
        {
            return htmlHelper.RenderExtPartial(partialViewName, viewData, model, IDMode.Explicit, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="viewData"></param>
        /// <param name="model"></param>
        /// <param name="idMode"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData, object model, IDMode idMode, string id)
        {
            return htmlHelper.RenderExtPartial(partialViewName, viewData, model, null, IDMode.Explicit, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="partialViewName"></param>
        /// <param name="viewData"></param>
        /// <param name="model"></param>
        /// <param name="tempData"></param>
        /// <param name="idMode"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string RenderExtPartial(this HtmlHelper htmlHelper, string partialViewName, ViewDataDictionary viewData, object model, TempDataDictionary tempData, IDMode idMode, string id)
        {
            if (String.IsNullOrEmpty(partialViewName))
            {
                throw new ArgumentException("Value cannot be null or empty.", "partialViewName");
            }

            return new PartialViewRenderer().Render(htmlHelper.ViewContext, partialViewName, viewData, model, tempData, idMode, id);
        }
    }
}