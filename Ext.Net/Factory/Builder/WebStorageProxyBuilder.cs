/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
        new public abstract partial class Builder<TWebStorageProxy, TBuilder> : AbstractProxy.Builder<TWebStorageProxy, TBuilder>
            where TWebStorageProxy : WebStorageProxy
            where TBuilder : Builder<TWebStorageProxy, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TWebStorageProxy component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The unique ID used as the key in which all record data are stored in the local storage object
			/// </summary>
            public virtual TBuilder StorageID(string storageID)
            {
                this.ToComponent().StorageID = storageID;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}