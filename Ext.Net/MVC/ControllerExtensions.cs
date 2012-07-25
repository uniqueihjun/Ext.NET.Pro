/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        public static PartialViewResult PartialExtView(this System.Web.Mvc.Controller controller)
        {
            return PartialExtView(controller, null /* viewName */, null /* model */);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static PartialViewResult PartialExtView(this System.Web.Mvc.Controller controller, object model)
        {
            return PartialExtView(controller, null /* viewName */, model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="viewName"></param>
        /// <returns></returns>
        public static PartialViewResult PartialExtView(this System.Web.Mvc.Controller controller, string viewName)
        {
            return PartialExtView(controller, viewName, null /* model */);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="viewName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static PartialViewResult PartialExtView(this System.Web.Mvc.Controller controller, string viewName, object model)
        {
            if (model != null)
            {
                controller.ViewData.Model = model;
            }

            return new PartialViewResult
            {
                ViewName = viewName,
                ViewData = controller.ViewData,
                TempData = controller.TempData
            };
        }
    }
}
