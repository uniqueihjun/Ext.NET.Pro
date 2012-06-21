/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class DefaultTabMenuCollectionBuilder<TParent, TParentBuilder>
         : AbstractComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : AbstractTabPanel
        where TParentBuilder : AbstractTabPanel.Builder<TParent, TParentBuilder>
    {
        /*  Ctor
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="builder"></param>
        public DefaultTabMenuCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public virtual DefaultTabMenuCollectionBuilder<TParent, TParentBuilder> Add(MenuBase menu)
        {
            this.Owner.DefaultTabMenu.Add(menu);
            return this;
        }
    }
}