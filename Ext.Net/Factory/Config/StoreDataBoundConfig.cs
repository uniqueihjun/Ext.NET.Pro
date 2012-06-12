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
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    public abstract partial class StoreDataBound
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : StoreBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private object dataSource = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual object DataSource 
			{ 
				get
				{
					return this.dataSource;
				}
				set
				{
					this.dataSource = value;
				}
			}

			private string dataSourceID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DataSourceID 
			{ 
				get
				{
					return this.dataSourceID;
				}
				set
				{
					this.dataSourceID = value;
				}
			}

			private string dataMember = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string DataMember 
			{ 
				get
				{
					return this.dataMember;
				}
				set
				{
					this.dataMember = value;
				}
			}

        }
    }
}