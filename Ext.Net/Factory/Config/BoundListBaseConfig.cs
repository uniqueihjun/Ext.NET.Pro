/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class BoundListBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractDataView.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int pageSize = 0;

			/// <summary>
			/// If greater than 0, a Ext.toolbar.Paging is displayed at the bottom of the list and store queries will execute with page start and limit parameters. Defaults to 0.
			/// </summary>
			[DefaultValue(0)]
			public virtual int PageSize 
			{ 
				get
				{
					return this.pageSize;
				}
				set
				{
					this.pageSize = value;
				}
			}

			private XTemplate itemTpl = null;

			/// <summary>
			/// The inner portion of the item template to be rendered. Follows an XTemplate structure and will be placed inside of a tpl.
			/// </summary>
			[DefaultValue(null)]
			public override XTemplate ItemTpl 
			{ 
				get
				{
					return this.itemTpl;
				}
				set
				{
					this.itemTpl = value;
				}
			}

        }
    }
}