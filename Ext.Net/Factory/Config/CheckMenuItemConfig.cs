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
    public partial class CheckMenuItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CheckMenuItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CheckMenuItem.Config Conversion to CheckMenuItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckMenuItem(CheckMenuItem.Config config)
        {
            return new CheckMenuItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MenuItemBase.Config 
        { 
			/*  Implicit CheckMenuItem.Config Conversion to CheckMenuItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CheckMenuItem.Builder(CheckMenuItem.Config config)
			{
				return new CheckMenuItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool _checked = false;

			/// <summary>
			/// True to initialize this checkbox as checked (defaults to false). Note that if this checkbox is part of a radio group (group = true) only the last item in the group that is initialized with checked = true will be rendered as checked.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Checked 
			{ 
				get
				{
					return this._checked;
				}
				set
				{
					this._checked = value;
				}
			}

			private string group = "";

			/// <summary>
			/// All check items with the same group name will automatically be grouped into a single-select radio button group (defaults to '').
			/// </summary>
			[DefaultValue("")]
			public virtual string Group 
			{ 
				get
				{
					return this.group;
				}
				set
				{
					this.group = value;
				}
			}

			private string groupClass = "";

			/// <summary>
			/// The default CSS class to use for radio group check items (defaults to \"x-menu-group-item\")
			/// </summary>
			[DefaultValue("")]
			public virtual string GroupClass 
			{ 
				get
				{
					return this.groupClass;
				}
				set
				{
					this.groupClass = value;
				}
			}

			private string checkHandler = "";

			/// <summary>
			/// A function that handles the checkchange event.
			/// </summary>
			[DefaultValue("")]
			public virtual string CheckHandler 
			{ 
				get
				{
					return this.checkHandler;
				}
				set
				{
					this.checkHandler = value;
				}
			}
        
			private CheckMenuItemListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public CheckMenuItemListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new CheckMenuItemListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private CheckMenuItemDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public CheckMenuItemDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new CheckMenuItemDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}