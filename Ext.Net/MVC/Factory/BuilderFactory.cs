/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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

namespace Ext.Net
{
    public partial class BuilderFactory
    {
        public HtmlHelper HtmlHelper
        {
            get;
            set;
        }
    }

    public partial class BuilderFactory<TModel> : BuilderFactory
    {
        HtmlHelper<TModel> htmlHelper;
        new public HtmlHelper<TModel> HtmlHelper
        {
            get
            {
                return this.htmlHelper;
            }
            set
            {
                this.htmlHelper = value;
                base.HtmlHelper = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class X
    {
        internal static BuilderFactory BuilderHelper(HtmlHelper htmlHelper)
        {
            return new BuilderFactory { HtmlHelper = htmlHelper };
        }

        internal static BuilderFactory<TModel> BuilderHelper<TModel>(HtmlHelper<TModel> htmlHelper)
        {
            return new BuilderFactory<TModel> { HtmlHelper = htmlHelper };
        }
    }

}