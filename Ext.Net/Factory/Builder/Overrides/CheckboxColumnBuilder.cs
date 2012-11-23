/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class CheckboxColumn
    {
		/// <summary>
		/// 
		/// </summary>
        public partial class Builder : Checkbox.Builder<CheckboxColumn, CheckboxColumn.Builder>
        {
            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual Builder Items(Action<CheckboxColumnItemsBuilder<CheckboxColumn, CheckboxColumn.Builder>> action)
            {
                action(new CheckboxColumnItemsBuilder<CheckboxColumn, CheckboxColumn.Builder>(this.ToComponent(), this));
                return this;
            }
        }
    }
}