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
    public partial class CycleButton
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCycleButton, TBuilder> : SplitButtonBase.Builder<TCycleButton, TBuilder>
            where TCycleButton : CycleButton
            where TBuilder : Builder<TCycleButton, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectChangeAction(string actionName)
            {
                this.ToComponent().DirectChangeUrl = this.UrlHelper.Action(actionName);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectChangeAction(string actionName, string controllerName)
            {
                this.ToComponent().DirectChangeUrl = this.UrlHelper.Action(actionName, controllerName);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectChangeAction(string actionName, object routeValues)
            {
                this.ToComponent().DirectChangeUrl = this.UrlHelper.Action(actionName, routeValues);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            public virtual TBuilder DirectChangeAction(string actionName, string controllerName, object routeValues)
            {
                this.ToComponent().DirectChangeUrl = this.UrlHelper.Action(actionName, controllerName, routeValues);
                return this as TBuilder;
            }
        }
    }
}