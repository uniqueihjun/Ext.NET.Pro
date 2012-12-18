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
    /// <summary>
    /// 
    /// </summary>
    public partial class Checkbox
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCheckbox, TBuilder> : CheckboxBase.Builder<TCheckbox, TBuilder>
            where TCheckbox : Checkbox
            where TBuilder : Builder<TCheckbox, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectCheckAction(string actionName)
            {
                this.ToComponent().DirectCheckUrl = this.UrlHelper.Action(actionName);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectCheckAction(string actionName, string controllerName)
            {
                this.ToComponent().DirectCheckUrl = this.UrlHelper.Action(actionName, controllerName);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectCheckAction(string actionName, object routeValues)
            {
                this.ToComponent().DirectCheckUrl = this.UrlHelper.Action(actionName, routeValues);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectCheckAction(string actionName, string controllerName, object routeValues)
            {
                this.ToComponent().DirectCheckUrl = this.UrlHelper.Action(actionName, controllerName, routeValues);
                return this as TBuilder;
            }
        }
    }
}