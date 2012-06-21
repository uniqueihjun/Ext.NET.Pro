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
    public partial class DateMenu
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DateMenu(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DateMenu.Config Conversion to DateMenu
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DateMenu(DateMenu.Config config)
        {
            return new DateMenu(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MenuBase.Config 
        { 
			/*  Implicit DateMenu.Config Conversion to DateMenu.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DateMenu.Builder(DateMenu.Config config)
			{
				return new DateMenu.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool hideOnClick = true;

			/// <summary>
			/// False to continue showing the menu after a date is selected, defaults to true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool HideOnClick 
			{ 
				get
				{
					return this.hideOnClick;
				}
				set
				{
					this.hideOnClick = value;
				}
			}
        
			private DatePicker picker = null;

			/// <summary>
			/// The Ext.DatePicker object
			/// </summary>
			public DatePicker Picker
			{
				get
				{
					if (this.picker == null)
					{
						this.picker = new DatePicker();
					}
			
					return this.picker;
				}
			}
			        
			private DateMenuListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DateMenuListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DateMenuListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DateMenuDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public DateMenuDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DateMenuDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}