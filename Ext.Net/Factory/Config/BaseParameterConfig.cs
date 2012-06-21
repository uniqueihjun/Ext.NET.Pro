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
    public abstract partial class BaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseItem.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string name = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
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

			private string value = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Value 
			{ 
				get
				{
					return this.value;
				}
				set
				{
					this.value = value;
				}
			}

			private ParameterMode mode = ParameterMode.Auto;

			/// <summary>
			/// Wrap in quotes or not
			/// </summary>
			[DefaultValue(ParameterMode.Auto)]
			public virtual ParameterMode Mode 
			{ 
				get
				{
					return this.mode;
				}
				set
				{
					this.mode = value;
				}
			}

			private bool encode = false;

			/// <summary>
			/// Encode value, it might be useful when value is js object
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Encode 
			{ 
				get
				{
					return this.encode;
				}
				set
				{
					this.encode = value;
				}
			}
        
			private ParameterCollection _params = null;

			/// <summary>
			/// 
			/// </summary>
			public ParameterCollection Params
			{
				get
				{
					if (this._params == null)
					{
						this._params = new ParameterCollection();
					}
			
					return this._params;
				}
			}
			
        }
    }
}