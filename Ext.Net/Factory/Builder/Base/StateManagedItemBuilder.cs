/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /*  Abstract
        -----------------------------------------------------------------------------------------------*/
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public partial class Builder<TItem, TBuilder>
            where TItem : StateManagedItem
            where TBuilder : Builder<TItem, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="item"></param>
            public Builder(TItem item)
            {
                this.item = item;
            }

            /// <summary>
            /// 
            /// </summary>
            protected TItem item;

            /// <summary>
            /// Get the instance of the underlying StateManagedItem.
            /// </summary>
            /// <returns>Control</returns>
            public virtual TItem ToComponent()
            {
                return this.item;
            }
        }
    }
}
