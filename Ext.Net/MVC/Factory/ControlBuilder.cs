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
using System.Web.UI;
using System.Web.Routing;

namespace Ext.Net
{
    public partial class ControlBuilder<TComponent, TBuilder>
        : IControlBuilder<TComponent>, IControlBuilder
        where TComponent : Control
        where TBuilder : ControlBuilder<TComponent, TBuilder>
    {
        public virtual ViewContext ViewContext
        {
            get
            {
                //var context = this.ToComponent().ViewContext ?? (ExtNet.Builder.HtmlHelper != null ? ExtNet.Builder.HtmlHelper.ViewContext : null);

                ViewContext context = null;

                if (this.ToComponent() is BaseControl)
                {
                    context = ((BaseControl)((object)this.ToComponent())).ViewContext;
                }

                if (context == null && ExtNet.Builder.HtmlHelper != null)
                {
                    context = ExtNet.Builder.HtmlHelper.ViewContext;
                }

                return context;
            }
        }

        public virtual UrlHelper UrlHelper
        {
            get
            {
                var context = this.ViewContext;
                return new UrlHelper(context != null ? context.RequestContext : new RequestContext(), RouteTable.Routes);
            }
        }
    }
}