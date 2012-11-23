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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

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
        new public abstract partial class Builder<TButtonBase, TBuilder> : ComponentBase.Builder<TButtonBase, TBuilder>
            where TButtonBase : ButtonBase
            where TBuilder : Builder<TButtonBase, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder MenuBuilder(Action<MenuCollectionBuilder<TButtonBase, TBuilder>> action)
            {
                action(new MenuCollectionBuilder<TButtonBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
            
            public virtual TBuilder MenuItem(AbstractComponent item)
            {
                var cmp = this.ToComponent();
                if (cmp.Menu.Count == 0)
                {
                    cmp.Menu.Add(new Menu());
                }
                
                cmp.Menu[0].Items.Add(item);

                return this as TBuilder;
            }

            public virtual TBuilder MenuItem(params AbstractComponent[] items)
            {
                foreach (var item in items)
                {
                    this.MenuItem(item);
                }

                return this as TBuilder;
            }

            public virtual TBuilder MenuItem(IEnumerable<AbstractComponent> items)
            {
                foreach (var item in items)
                {
                    this.MenuItem(item);
                }

                return this as TBuilder;
            }

            public virtual TBuilder Menu(MenuBase menu)
            {
                this.ToComponent().Menu.Add(menu);
                return this as TBuilder;
            }			 
        }        
    }
}