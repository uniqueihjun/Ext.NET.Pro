/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public abstract partial class WebStorageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractProxy.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string storageID = "";

			/// <summary>
			/// The unique ID used as the key in which all record data are stored in the local storage object
			/// </summary>
			[DefaultValue("")]
			public virtual string StorageID 
			{ 
				get
				{
					return this.storageID;
				}
				set
				{
					this.storageID = value;
				}
			}

        }
    }
}