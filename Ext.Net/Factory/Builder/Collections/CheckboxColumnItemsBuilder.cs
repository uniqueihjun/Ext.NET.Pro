/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System.ComponentModel;
using System.Web.UI;
using System;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class CheckboxColumnItemsBuilder<TParent, TParentBuilder>
        : ComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : CheckboxColumn
        where TParentBuilder : CheckboxColumn.Builder<TParent, TParentBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public CheckboxColumnItemsBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public virtual CheckboxColumnItemsBuilder<TParent, TParentBuilder> Add(Component component)
        {
            this.Owner.Items.Add(component);
            return this;
        }

        // TODO: .Add(Control control) // add to .Content() collection
        // TODO: .Add(Func)            // add to .Content() collection

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public virtual CheckboxColumnItemsBuilder<TParent, TParentBuilder> Add(Component.Builder<TParent, TParentBuilder> builder)
        {
            this.Add(builder.ToComponent());
            return this;
        }
    }
}