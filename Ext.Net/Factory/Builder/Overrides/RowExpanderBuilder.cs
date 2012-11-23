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

namespace Ext.Net
{
    public partial class RowExpander
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRowExpander, TBuilder> : Plugin.Builder<TRowExpander, TBuilder>
            where TRowExpander : RowExpander
            where TBuilder : Builder<TRowExpander, TBuilder>
        {
            /// <summary>
			/// The template string to use to display each item in the dropdown list.
 			/// </summary>
            /// <param name="html">The template html</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder TemplateHtml(string html)
            {
                this.ToComponent().Template.Html = html;
                return this as TBuilder;
            }

            public virtual TBuilder TemplateHtml(Func<object, object> html)
            {
                object result = html(null);
                this.ToComponent().Template.Html = result.ToString();

                return this as TBuilder;
            }

            // <summary>
            /// 
            /// </summary>
            /// <param name="action">The action delegate</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Component(AbstractComponent component)
            {
                this.ToComponent().Component.Add(component);
                return this as TBuilder;
            }

            /// <summary>
            /// A renderer is an 'interceptor' method which can be used transform data (value, appearance, etc.) before it is rendered.
            /// </summary>
            public virtual TBuilder Renderer(string handler)
            {
                this.ToComponent().Renderer = new Renderer(handler);
                return this as TBuilder;
            }
        }
    }
}