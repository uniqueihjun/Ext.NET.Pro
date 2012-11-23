/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ActionColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TActionColumn, TBuilder> : ColumnBase.Builder<TActionColumn, TBuilder>
            where TActionColumn : ActionColumn
            where TBuilder : Builder<TActionColumn, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="actions"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Items(params ActionItem[] actions)
            {
                this.ToComponent().Items.AddRange(actions);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="actions"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Items(IEnumerable<ActionItem> actions)
            {
                this.ToComponent().Items.AddRange(actions);
                return this as TBuilder;
            }
        }
    }
}