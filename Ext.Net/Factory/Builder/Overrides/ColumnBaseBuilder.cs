/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public abstract partial class ColumnBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TColumnBase, TBuilder> : ComponentBase.Builder<TColumnBase, TBuilder>
            where TColumnBase : ColumnBase
            where TBuilder : Builder<TColumnBase, TBuilder>
        {
            /// <summary>
			/// Specify as true to constrain column dragging so that a column cannot be dragged into or out of this column. Note that this config is only valid for column headers which contain child column headers.
			/// </summary>
            public virtual TBuilder Sealed(bool @sealed)
            {
                this.ToComponent().Sealed = @sealed;
                return this as TBuilder;
            }			
        }        
    }
}