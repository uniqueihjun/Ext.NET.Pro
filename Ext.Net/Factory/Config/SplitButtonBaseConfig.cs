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
    public abstract partial class SplitButtonBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ButtonBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string arrowHandler = "";

			/// <summary>
			/// A function called when the arrow button is clicked (can be used instead of click event).
			/// </summary>
			[DefaultValue("")]
			public virtual string ArrowHandler 
			{ 
				get
				{
					return this.arrowHandler;
				}
				set
				{
					this.arrowHandler = value;
				}
			}

			private string arrowTooltip = "";

			/// <summary>
			/// The title attribute of the arrow.
			/// </summary>
			[DefaultValue("")]
			public virtual string ArrowTooltip 
			{ 
				get
				{
					return this.arrowTooltip;
				}
				set
				{
					this.arrowTooltip = value;
				}
			}

        }
    }
}