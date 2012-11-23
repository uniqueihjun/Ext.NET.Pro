/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.Web.Mvc;

namespace Ext.Net.MVC
{
    /// <summary>
    /// 
    /// </summary>
    public static class GeneralExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static BuilderFactory X(this HtmlHelper htmlHelper)
        {
            Ext.Net.X.Builder.HtmlHelper = htmlHelper;
            return Ext.Net.X.BuilderHelper(htmlHelper);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static BuilderFactory<TModel> X<TModel>(this HtmlHelper<TModel> htmlHelper)
        {
            Ext.Net.X.Builder.HtmlHelper = htmlHelper;
            return Ext.Net.X.BuilderHelper<TModel>(htmlHelper);
        }
    }
}