/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ItemsBuilder<TParent, TParentBuilder>
        : ComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : ContainerBase
        where TParentBuilder : ContainerBase.Builder<TParent, TParentBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ItemsBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        public virtual ItemsBuilder<TParent, TParentBuilder> Add(Component component)
        {
            this.Owner.Items.Add(component);
            return this;
        }

        /// TODO: .Add(Control control) // add to .Content() collection
        /// TODO: .Add(Func)            // add to .Content() collection

        public virtual ItemsBuilder<TParent, TParentBuilder> Add(Component.Builder<TParent, TParentBuilder> builder)
        {
            this.Add(builder.ToComponent());
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual ItemsBuilder<TParent, TParentBuilder> AddRange(Component[] components)
        {
            this.Owner.Items.AddRange(components);
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual ItemsBuilder<TParent, TParentBuilder> AddRange(Component.Builder<TParent, TParentBuilder>[] builders)
        {
            this.AddRange(builders);
            return this;
        }
    }
}