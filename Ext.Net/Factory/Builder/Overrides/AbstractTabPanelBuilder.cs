/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class AbstractTabPanel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TAbstractTabPanel"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TAbstractTabPanel, TBuilder> : AbstractPanel.Builder<TAbstractTabPanel, TBuilder>
            where TAbstractTabPanel : AbstractTabPanel
            where TBuilder : Builder<TAbstractTabPanel, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder DefaultTabMenuBuilder(Action<DefaultTabMenuCollectionBuilder<TAbstractTabPanel, TBuilder>> action)
            {
                action(new DefaultTabMenuCollectionBuilder<TAbstractTabPanel, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }
    }
}