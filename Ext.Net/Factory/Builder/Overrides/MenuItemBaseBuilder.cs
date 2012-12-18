/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public abstract partial class MenuItemBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TMenuItemBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TMenuItemBase, TBuilder> : ComponentBase.Builder<TMenuItemBase, TBuilder>
            where TMenuItemBase : MenuItemBase
            where TBuilder : Builder<TMenuItemBase, TBuilder>
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="action"></param>
            /// <returns></returns>
            public virtual TBuilder MenuBuilder(Action<MenuItemBaseMenuCollectionBuilder<TMenuItemBase, TBuilder>> action)
            {
                action(new MenuItemBaseMenuCollectionBuilder<TMenuItemBase, TBuilder>(this.ToComponent(), this as TBuilder));
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
                foreach (AbstractComponent item in items)
                {
                    this.MenuItem(item);
                }

                return this as TBuilder;
            }

            public virtual TBuilder MenuItem(IEnumerable<AbstractComponent> items)
            {
                foreach (AbstractComponent item in items)
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