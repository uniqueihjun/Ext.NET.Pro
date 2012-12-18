/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class AbstractComponent
    {
        new public abstract partial class Builder<TAbstractComponent, TBuilder> : Observable.Builder<TAbstractComponent, TBuilder>
            where TAbstractComponent : AbstractComponent
            where TBuilder : Builder<TAbstractComponent, TBuilder>
        {
            /// <summary>
            /// In layout pages, renders the content of a named section to content area of the widget
            /// </summary>
            /// <param name="page"></param>
            /// <param name="name"></param>
            /// <param name="required"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromSection(System.Web.WebPages.WebPageBase page, string name, bool required)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = page.RenderSection(name, required);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// In layout pages, renders the content of a named section to content area of the widget
            /// </summary>
            /// <param name="page"></param>
            /// <param name="name"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromSection(System.Web.WebPages.WebPageBase page, string name)
            {
                return this.ContentFromSection(page, name, false);
            }

            /// <summary>
            /// Renders the content of one page within another page to content area of the widget
            /// </summary>
            /// <param name="page"></param>
            /// <param name="path"></param>
            /// <param name="data"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromPage(System.Web.WebPages.WebPageBase page, string path, params object[] data)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = page.RenderPage(path, data);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName, object routeValues)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, routeValues);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }
            
            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName, string controllerName)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName, System.Web.Routing.RouteValueDictionary routeValues)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, routeValues);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName, string controllerName, object routeValues)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName, routeValues);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Invokes the specified action methods and use the result as content
            /// </summary>
            /// <param name="actionName"></param>
            /// <param name="controllerName"></param>
            /// <param name="routeValues"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromAction(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Action(actionName, controllerName, routeValues);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as content
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromPartial(string partialViewName, object model, ViewDataDictionary viewData)
            {
                BaseControl.SectionsStack.Push(null);
                ResourceManager.ScriptOrderNextRange();
                var result = Ext.Net.X.Builder.HtmlHelper.Partial(partialViewName, model, viewData);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                ResourceManager.ScriptOrderPrevRange();
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// Render specified partial view as content
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromPartial(string partialViewName, object model)
            {
                return this.ContentFromPartial(partialViewName, model, null);
            }

            /// <summary>
            /// Render specified partial view as content
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromPartial(string partialViewName, ViewDataDictionary viewData)
            {
                return this.ContentFromPartial(partialViewName, null, viewData);
            }

            /// <summary>
            /// Render specified partial view as content
            /// </summary>
            /// <param name="partialViewName"></param>
            /// <returns></returns>
            public virtual TBuilder ContentFromPartial(string partialViewName)
            {
                return this.ContentFromPartial(partialViewName, null, null);
            }
        }
    }
}