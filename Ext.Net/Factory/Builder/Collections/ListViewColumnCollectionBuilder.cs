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
    public partial class ListViewColumnCollectionBuilder<TParent, TParentBuilder>
        : ComponentCollectionBuilder<TParent, TParentBuilder>
        where TParent : ListView
        where TParentBuilder : ListView.Builder<TParent, TParentBuilder>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ListViewColumnCollectionBuilder(TParent owner, TParentBuilder builder) : base(owner, builder) { }


        /*  Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listViewColumn"></param>
        /// <returns></returns>
        public virtual ListViewColumnCollectionBuilder<TParent, TParentBuilder> Add(ListViewColumn listViewColumn)
        {
            this.Owner.Columns.Add(listViewColumn);
            return this;
        }
    }
}