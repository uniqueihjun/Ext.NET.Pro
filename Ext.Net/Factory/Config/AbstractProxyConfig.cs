/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public abstract partial class AbstractProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool batchActions = true;

			/// <summary>
			/// True to batch actions of a particular type when synchronizing the store. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool BatchActions 
			{ 
				get
				{
					return this.batchActions;
				}
				set
				{
					this.batchActions = value;
				}
			}

			private string batchOrder = "create,update,destroy";

			/// <summary>
			/// Comma-separated ordering 'create', 'update' and 'destroy' actions when batching. Override this to set a different order for the batched CRUD actions to be executed in. Defaults to 'create,update,destroy'
			/// </summary>
			[DefaultValue("create,update,destroy")]
			public virtual string BatchOrder 
			{ 
				get
				{
					return this.batchOrder;
				}
				set
				{
					this.batchOrder = value;
				}
			}

        }
    }
}