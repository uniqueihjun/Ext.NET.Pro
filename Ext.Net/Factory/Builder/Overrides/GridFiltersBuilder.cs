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
    public partial class GridFilters
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGridFilters, TBuilder> : GridFeature.Builder<TGridFilters, TBuilder>
            where TGridFilters : GridFilters
            where TBuilder : Builder<TGridFilters, TBuilder>
        {
            /// <summary>
            /// An Array of filters config objects.
            /// </summary>
            /// <param name="filters">an array of filters</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Filters(params GridFilter[] filters)
            {
                this.ToComponent().Filters.AddRange(filters);
                return this as TBuilder;
            }

            /// <summary>
            /// An Array of filters config objects.
            /// </summary>
            /// <param name="filters">a collection of filters</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Filters(IEnumerable<GridFilter> filters)
            {
                this.ToComponent().Filters.AddRange(filters);
                return this as TBuilder;
            }
        }
    }
}