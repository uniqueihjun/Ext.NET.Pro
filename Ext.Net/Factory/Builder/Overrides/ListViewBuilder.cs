/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
	[Description("")]
    public partial class ListView
    {
		/// <summary>
		/// 
		/// </summary>
        public partial class Builder : DataView.Builder<ListView, ListView.Builder>
        {
            /// <summary>
            /// An array of column configuration objects
            /// </summary>
            [Description("An array of column configuration objects")]
            public virtual Builder Items(Action<ListViewColumnCollectionBuilder<ListView, Builder>> action)
            {
                action(new ListViewColumnCollectionBuilder<ListView, Builder>(this.ToComponent(), this));
                return this;
            }
        }
    }
}