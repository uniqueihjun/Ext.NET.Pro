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
    public abstract partial class TreeStoreBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTreeStoreBase, TBuilder> : AbstractStore.Builder<TTreeStoreBase, TBuilder>
            where TTreeStoreBase : TreeStoreBase
            where TBuilder : Builder<TTreeStoreBase, TBuilder>
        {           
 			/// <summary>
			/// The root node for the tree.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>            
            public virtual TBuilder Root(Node root)
            {
                this.ToComponent().Root.Add(root);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DataBindings(params NodeBinding[] nodeBindings)
            {
                this.ToComponent().DataBindings.AddRange(nodeBindings);
                return this as TBuilder;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="action">The action delegate</param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DataBindings(IEnumerable<NodeBinding> nodeBindings)
            {
                this.ToComponent().DataBindings.AddRange(nodeBindings);
                return this as TBuilder;
            }
        }        
    }
}