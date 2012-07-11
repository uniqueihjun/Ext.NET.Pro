/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class ComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : Component
        where TParentBuilder : Component.Builder<TParent, TParentBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
        public ComponentCollectionBuilder(TParent owner, TParentBuilder builder)
        {
            this.Owner = owner;
            this.Builder = builder;
        }
    

        /*  Properties
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        protected internal virtual TParent Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
        protected virtual TParentBuilder Builder { get; set; }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TParentBuilder Parent()
        {
            return this.Builder as TParentBuilder;
        }
    }
}