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
    public abstract partial class SpinnerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : TriggerFieldBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool keyNavEnabled = true;

			/// <summary>
			/// Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool KeyNavEnabled 
			{ 
				get
				{
					return this.keyNavEnabled;
				}
				set
				{
					this.keyNavEnabled = value;
				}
			}

			private bool mouseWheelEnabled = true;

			/// <summary>
			/// Specifies whether the mouse wheel should trigger spinning up and down while the field has focus. Defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool MouseWheelEnabled 
			{ 
				get
				{
					return this.mouseWheelEnabled;
				}
				set
				{
					this.mouseWheelEnabled = value;
				}
			}

			private bool spinDownEnabled = true;

			/// <summary>
			/// Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinDownEnabled method.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool SpinDownEnabled 
			{ 
				get
				{
					return this.spinDownEnabled;
				}
				set
				{
					this.spinDownEnabled = value;
				}
			}

			private bool spinUpEnabled = true;

			/// <summary>
			/// Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is created, use the setSpinUpEnabled method.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool SpinUpEnabled 
			{ 
				get
				{
					return this.spinUpEnabled;
				}
				set
				{
					this.spinUpEnabled = value;
				}
			}

        }
    }
}