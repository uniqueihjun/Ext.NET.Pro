/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class ButtonsCollectionBuilder<TParent, TParentBuilder>
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
        [Description("")]
        public ButtonsCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        [Description("")]
        public virtual ButtonsCollectionBuilder<TParent, TParentBuilder> Add(Button.Builder builder)
        {
            this.Owner.Buttons.Add(builder.ToComponent());
            return this;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual ButtonsCollectionBuilder<TParent, TParentBuilder> Add(ButtonBase button)
        {
            this.Owner.Buttons.Add(button);
            return this;
        }
    }
}