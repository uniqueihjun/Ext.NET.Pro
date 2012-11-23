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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class GridPanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TGridPanelBase, TBuilder> : TablePanel.Builder<TGridPanelBase, TBuilder>
            where TGridPanelBase : GridPanelBase
            where TBuilder : Builder<TGridPanelBase, TBuilder>
        {
            public virtual TBuilder Store(Store store)
            {
                this.ToComponent().Store.Add(store);
                return this as TBuilder;
            }

            /// <summary>
            /// The Ext.grid.View used by the grid. This can be set before a call to render().
            /// </summary>
            /// <param name="view">view</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder View(GridView view)
            {
                this.ToComponent().View.Add(view);
                return this as TBuilder;
            }

            /// <summary>
            /// An array of grid features
            /// </summary>
            /// <param name="features"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Features(params GridFeature[] features)
            {
                this.ToComponent().Features.AddRange(features);
                return this as TBuilder;
            }

            /// <summary>
            /// An array of grid features
            /// </summary>
            /// <param name="features"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Features(IEnumerable<GridFeature> features)
            {
                this.ToComponent().Features.AddRange(features);
                return this as TBuilder;
            }
        }        
    }
}