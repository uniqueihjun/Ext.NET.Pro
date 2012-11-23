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
    public partial class Node
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TNode, TBuilder> : BaseItem.Builder<TNode, TBuilder>
            where TNode : Node
            where TBuilder : Builder<TNode, TBuilder>
        {
             
 			/// <summary>
			/// Array of child nodes.
 			/// </summary>
 			/// <param name="nodes"></param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Children(params Node[] nodes)
            {
                this.ToComponent().Children.AddRange(nodes);
                return this as TBuilder;
            }

            /// <summary>
            /// Array of child nodes.
            /// </summary>
            /// <param name="nodes"></param>
            /// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Children(IEnumerable<Node> nodes)
            {
                this.ToComponent().Children.AddRange(nodes);
                return this as TBuilder;
            }
			 
 			 
 			/// <summary>
			/// Collection of custom node attributes
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder CustomAttributes(object attributes)
            {
                this.ToComponent().CustomAttributes.Add(attributes);
                return this as TBuilder;
            }			
        }		
    }    
}