/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web;
using System.Linq.Expressions;
using System.Web.Routing;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractContainer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractContainer"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractContainer, TBuilder> : ComponentBase.Builder<TAbstractContainer, TBuilder>
            where TAbstractContainer : AbstractContainer
            where TBuilder : Builder<TAbstractContainer, TBuilder>
        {
            /// <summary>
            /// In layout pages, renders the content of a named section as items and specifies whether the section is required.
            /// </summary>
            /// <param name="page">Page instance</param>
            /// <param name="name">Section name to render as items</param>
            /// <param name="required">True to specify that the section is required</param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromSection(System.Web.WebPages.WebPageBase page, string name, bool required)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = page.RenderSection(name, required);

                this.HandleResult(result);

                return this as TBuilder;
            }

            private void HandleResult(IHtmlString result)
            {
                if (result != null)
                {
                    var items = result.ToHtmlString();
                    var ids = BaseControl.SectionsStack.Pop();
                    var cmp = this.ToComponent();

                    if (cmp.ItemsToRender != null)
                    {
                        cmp.ItemsToRender += items;
                    }
                    else
                    {
                        cmp.ItemsToRender = items;
                    }

                    if (cmp.IDSToRender != null)
                    {
                        cmp.IDSToRender.AddRange(ids);
                    }
                    else
                    {
                        cmp.IDSToRender = ids;
                    }
                }
                else
                {
                    BaseControl.SectionsStack.Pop();
                }
            }            

            /// <summary>
            /// In layout pages, renders the content of a named section as items
            /// </summary>
            /// <param name="page">Page instance</param>
            /// <param name="name">Section name to render as items</param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromSection(System.Web.WebPages.WebPageBase page, string name)
            {
                return this.ItemsFromSection(page, name, false);
            }

            /// <summary>
            /// Renders the content of one page within another page as items.
            /// </summary>
            /// <param name="page">Page instance</param>
            /// <param name="path">The path of the page to render.</param>
            /// <param name="data">(Optional) An array of data to pass to the page being rendered. In the rendered page, these parameters can be accessed by using the PageData property.</param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromPage(System.Web.WebPages.WebPageBase page, string path, params object[] data)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = page.RenderPage(path, data);

                this.HandleResult(result);

                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName, object routeValues)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, routeValues);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName, string controllerName)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName, System.Web.Routing.RouteValueDictionary routeValues)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, routeValues);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName, string controllerName, object routeValues)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName, routeValues);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as items
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromAction(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName, routeValues);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as items
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <param name="model"></param>
            /// <param name="viewData"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromPartial(string partialViewName, object model, ViewDataDictionary viewData)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Partial(partialViewName, model, viewData);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as items
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <param name="model"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromPartial(string partialViewName, object model)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Partial(partialViewName, model);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as items
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <param name="viewData"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromPartial(string partialViewName, ViewDataDictionary viewData)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Partial(partialViewName, viewData);
                this.HandleResult(result);
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as items
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <returns></returns>
            public virtual TBuilder ItemsFromPartial(string partialViewName)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                var result = Ext.Net.X.Builder.HtmlHelper.Partial(partialViewName);
                this.HandleResult(result);
                return this as TBuilder;
            }

            public virtual TBuilder ItemsFrom(Func<TBuilder, IHtmlString> func)
            {
                BaseControl.SectionsStack.Push(new List<string>());
                this.HandleResult(func(this as TBuilder));
                return this as TBuilder;
            }
        }
    }
}