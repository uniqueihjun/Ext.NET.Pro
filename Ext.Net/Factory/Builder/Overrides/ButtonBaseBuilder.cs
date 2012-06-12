/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class ButtonBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TButtonBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TButtonBase, TBuilder> : BoxComponent.Builder<TButtonBase, TBuilder>
            where TButtonBase : ButtonBase
            where TBuilder : Builder<TButtonBase, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder Menu(Action<MenuCollectionBuilder<TButtonBase, TBuilder>> action)
            {
                action(new MenuCollectionBuilder<TButtonBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }        
    }
}