/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class TBarCollectionBuilder<TParent, TParentBuilder>
         : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : AbstractPanel
        where TParentBuilder : AbstractPanel.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public TBarCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public virtual TBarCollectionBuilder<TParent, TParentBuilder> Add(Toolbar.Builder builder)
        {
            this.Owner.TopBar.Add(builder.ToComponent());
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual TBarCollectionBuilder<TParent, TParentBuilder> Add(ToolbarBase toolbar)
        {
            this.Owner.TopBar.Add(toolbar);
            return this;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TParentBuilder"></typeparam>
    public partial class BBarCollectionBuilder<TParent, TParentBuilder>
        : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : AbstractPanel
        where TParentBuilder : AbstractPanel.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public BBarCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public virtual BBarCollectionBuilder<TParent, TParentBuilder> Add(Toolbar.Builder builder)
        {
            this.Owner.BottomBar.Add(builder.ToComponent());
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual BBarCollectionBuilder<TParent, TParentBuilder> Add(ToolbarBase toolbar)
        {
            this.Owner.BottomBar.Add(toolbar);
            return this;
        }

        //public virtual TComponentBuilder Add(Action<AbstractComponent.Builder<TComponent, TComponentBuilder>> action)
        //{

        //    //action(new AbstractComponent.Builder<TComponent, TComponentBuilder>(this.Owner, this as TParentBuilder));
        //    return this;
        //}
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TParentBuilder"></typeparam>
    public partial class FBarCollectionBuilder<TParent, TParentBuilder>
         : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : AbstractPanel
        where TParentBuilder : AbstractPanel.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public FBarCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public virtual FBarCollectionBuilder<TParent, TParentBuilder> Add(Toolbar.Builder builder)
        {
            this.Owner.FooterBar.Add(builder.ToComponent());
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
        public virtual FBarCollectionBuilder<TParent, TParentBuilder> Add(ToolbarBase toolbar)
        {
            this.Owner.FooterBar.Add(toolbar);
            return this;
        }
    }
}