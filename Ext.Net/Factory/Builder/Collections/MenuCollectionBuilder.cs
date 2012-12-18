/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class MenuCollectionBuilder<TParent, TParentBuilder>
         : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : ButtonBase
        where TParentBuilder : ButtonBase.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public MenuCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public virtual MenuCollectionBuilder<TParent, TParentBuilder> Add(MenuBase menu)
        {
            this.Owner.Menu.Add(menu);
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual MenuItem.Builder Add(Action<MenuItem, MenuItem.Builder> action)
        {
            MenuItem.Builder builder = new MenuItem.Builder(new MenuItem());
            action(builder.ToComponent(), builder);
            return builder;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TParentBuilder"></typeparam>
    public partial class MenuItemBaseMenuCollectionBuilder<TParent, TParentBuilder>
         : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : MenuItemBase
        where TParentBuilder : MenuItemBase.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public MenuItemBaseMenuCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public virtual MenuItemBaseMenuCollectionBuilder<TParent, TParentBuilder> Add(MenuBase menu)
        {
            this.Owner.Menu.Add(menu);
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual MenuItem.Builder Add(Action<MenuItem, MenuItem.Builder> action)
        {
            MenuItem.Builder builder = new MenuItem.Builder(new MenuItem());
            action(builder.ToComponent(), builder);
            return builder;
        }

        //public virtual TBuilder Items(Action<ItemsBuilder<TContainerBase, TBuilder>> action)
        //{
        //    action(new ItemsBuilder<TContainerBase, TBuilder>(this.ToControl(), this as TBuilder));
        //    return this as TBuilder;
        //}
    }
}