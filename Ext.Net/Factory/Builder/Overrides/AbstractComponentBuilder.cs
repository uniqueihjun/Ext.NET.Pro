/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                var result = page.RenderSection(name, required);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
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
                var result = page.RenderPage(path, data);
                if (result != null)
                {
                    this.ToComponent().ContentControls.Add(new LiteralControl(result.ToHtmlString()));
                }
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="content"></param>
            /// <returns></returns>
            public virtual TBuilder Content(Func<object, object> content)
            {
                BaseControl.SectionsStack.Push(null);
                var result = content(null);
                this.ToComponent().ContentControls.Add(new LiteralControl(result.ToString()));
                BaseControl.SectionsStack.Pop();
                return this as TBuilder;
            }

            /// <summary>
            /// The width of this component in pixels.
            /// </summary>
            public virtual TBuilder Width(int width)
            {
                this.ToComponent().Width = Unit.Pixel(width);
                return this as TBuilder;
            }

            /// <summary>
            /// The width of this component in pixels.
            /// </summary>
            public virtual TBuilder Height(int height)
            {
                this.ToComponent().Height = Unit.Pixel(height);
                return this as TBuilder;
            }

            /// <summary>
            /// The page level x coordinate for this component if contained within a positioning container.
            /// </summary>
            public virtual TBuilder PageX(int pageX)
            {
                this.ToComponent().PageX = Unit.Pixel(pageX);
                return this as TBuilder;
            }

            /// <summary>
            /// The page level y coordinate for this component if contained within a positioning container.
            /// </summary>
            public virtual TBuilder PageY(int pageY)
            {
                this.ToComponent().PageY = Unit.Pixel(pageY);
                return this as TBuilder;
            }            
        }
    }
}