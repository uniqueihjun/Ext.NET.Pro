/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.Net
{
    public partial class MvcItem
    {
        public partial class Builder : MvcItem.Builder<MvcItem, MvcItem.Builder>
        {
            public Builder(Func<System.Web.IHtmlString> expression)
                : this()
            {
                this.ToComponent().Expression = expression;
            }
        }
    }

    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public MvcItem.Builder MvcItem(Func<System.Web.IHtmlString> expression)
        {
            return new MvcItem.Builder(expression);
        }
    }
}