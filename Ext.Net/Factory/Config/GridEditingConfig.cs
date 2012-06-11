/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class GridEditing
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Plugin.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private int clicksToEdit = 2;

			/// <summary>
			/// The number of clicks on a grid required to display the editor (defaults to 2).
			/// </summary>
			[DefaultValue(2)]
			public virtual int ClicksToEdit 
			{ 
				get
				{
					return this.clicksToEdit;
				}
				set
				{
					this.clicksToEdit = value;
				}
			}

			private string triggerEvent = "";

			/// <summary>
			/// The event which triggers editing. Supercedes the clicksToEdit configuration.
			/// </summary>
			[DefaultValue("")]
			public virtual string TriggerEvent 
			{ 
				get
				{
					return this.triggerEvent;
				}
				set
				{
					this.triggerEvent = value;
				}
			}

        }
    }
}