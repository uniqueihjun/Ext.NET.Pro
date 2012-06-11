/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public abstract partial class Observable
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : XControl.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ConfigItemCollection customConfig = null;

			/// <summary>
			/// Collection of custom js config
			/// </summary>
			public ConfigItemCollection CustomConfig
			{
				get
				{
					if (this.customConfig == null)
					{
						this.customConfig = new ConfigItemCollection();
					}
			
					return this.customConfig;
				}
			}
			
        }
    }
}