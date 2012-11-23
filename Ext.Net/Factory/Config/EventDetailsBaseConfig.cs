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
    public abstract partial class EventDetailsBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : FormPanelBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string title = "Event Form";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("Event Form")]
			public override string Title 
			{ 
				get
				{
					return this.title;
				}
				set
				{
					this.title = value;
				}
			}

			private string titleTextAdd = "Add Event";

			/// <summary>
			/// The title during event adding
			/// </summary>
			[DefaultValue("Add Event")]
			public virtual string TitleTextAdd 
			{ 
				get
				{
					return this.titleTextAdd;
				}
				set
				{
					this.titleTextAdd = value;
				}
			}

			private string titleTextEdit = "Edit Event";

			/// <summary>
			/// The title during event editing
			/// </summary>
			[DefaultValue("Edit Event")]
			public virtual string TitleTextEdit 
			{ 
				get
				{
					return this.titleTextEdit;
				}
				set
				{
					this.titleTextEdit = value;
				}
			}

			private Alignment buttonAlign = Alignment.Center;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(Alignment.Center)]
			public override Alignment ButtonAlign 
			{ 
				get
				{
					return this.buttonAlign;
				}
				set
				{
					this.buttonAlign = value;
				}
			}

			private string calendarStoreID = "";

			/// <summary>
			/// The calendar store ID to use.
			/// </summary>
			[DefaultValue("")]
			public virtual string CalendarStoreID 
			{ 
				get
				{
					return this.calendarStoreID;
				}
				set
				{
					this.calendarStoreID = value;
				}
			}

        }
    }
}