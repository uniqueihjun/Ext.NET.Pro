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
    public abstract partial class ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Observable.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string[] models = null;

			/// <summary>
			/// Array of models to require from AppName.model namespace.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Models 
			{ 
				get
				{
					return this.models;
				}
				set
				{
					this.models = value;
				}
			}

			private string[] stores = null;

			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Stores 
			{ 
				get
				{
					return this.stores;
				}
				set
				{
					this.stores = value;
				}
			}

			private string[] views = null;

			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Views 
			{ 
				get
				{
					return this.views;
				}
				set
				{
					this.views = value;
				}
			}

			private string name = null;

			/// <summary>
			/// The controller name. Required
			/// </summary>
			[DefaultValue(null)]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

        }
    }
}