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
    public abstract partial class TreePanelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TTreePanelBase, TBuilder> : TablePanel.Builder<TTreePanelBase, TBuilder>
            where TTreePanelBase : TreePanelBase
            where TBuilder : Builder<TTreePanelBase, TBuilder>
        {
            public virtual TBuilder Store(TreeStore store)
            {
                this.ToComponent().Store.Add(store);
                return this as TBuilder;
            }

            /// <summary>
            /// Allows you to not specify a store on this TreePanel. This is useful for creating a simple tree with preloaded data without having to specify a TreeStore and Model. A store and model will be created and root will be passed to that store.
            /// </summary>
            /// <param name="root"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Root(Node root)
            {
                this.ToComponent().Root.Add(root);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="model"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Model(Model model)
            {
                this.ToComponent().Model.Add(model);
                return this as TBuilder;
            }

            /// <summary>
            /// The Ext.grid.View used by the grid. This can be set before a call to render().
            /// </summary>
            /// <param name="view"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder View(TreeView view)
            {
                this.ToComponent().View.Add(view);
                return this as TBuilder;
            }

            /// <summary>
            /// An array of fields definition objects
            /// </summary>
            /// <param name="fields"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Fields(params ModelField[] fields)
            {
                this.ToComponent().Fields.AddRange(fields);
                return this as TBuilder;
            }

            /// <summary>
            /// An array of fields definition objects
            /// </summary>
            /// <param name="fields"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Fields(IEnumerable<ModelField> fields)
            {
                this.ToComponent().Fields.AddRange(fields);
                return this as TBuilder;
            }
        }
    }
}