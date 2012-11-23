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
    public partial class ListFilter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TListFilter, TBuilder> : GridFilter.Builder<TListFilter, TBuilder>
            where TListFilter : ListFilter
            where TBuilder : Builder<TListFilter, TBuilder>
        {
            /// <summary>
            /// The list of options
            /// </summary>
            public virtual TBuilder Options(string options)
            {
                this.ToComponent().Options = options.Split(',');
                return this as TBuilder;
            }

            /// <summary>
            /// The list of options
            /// </summary>
            public virtual TBuilder Value(string value)
            {
                this.ToComponent().Value = value.Split(',');
                return this as TBuilder;
            }
        }        
    }
}