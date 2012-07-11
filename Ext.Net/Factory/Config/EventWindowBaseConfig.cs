/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class EventWindowBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : AbstractWindow.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
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

			private Unit width = Unit.Pixel(600);

			/// <summary>
			/// The width of this component in pixels (defaults to auto).
			/// </summary>
			[DefaultValue(typeof(Unit), "600")]
			public override Unit Width 
			{ 
				get
				{
					return this.width;
				}
				set
				{
					this.width = value;
				}
			}

			private string deletingMessage = "Deleting event...";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("Deleting event...")]
			public virtual string DeletingMessage 
			{ 
				get
				{
					return this.deletingMessage;
				}
				set
				{
					this.deletingMessage = value;
				}
			}

			private string savingMessage = "Saving changes...";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("Saving changes...")]
			public virtual string SavingMessage 
			{ 
				get
				{
					return this.savingMessage;
				}
				set
				{
					this.savingMessage = value;
				}
			}

			private bool resizable = false;

			/// <summary>
			/// True to allow user resizing at each edge and corner of the window, false to disable resizing (defaults to true).
			/// </summary>
			[DefaultValue(false)]
			public override bool Resizable 
			{ 
				get
				{
					return this.resizable;
				}
				set
				{
					this.resizable = value;
				}
			}

			private Alignment buttonAlign = Alignment.Left;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(Alignment.Left)]
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

			private Unit height = Unit.Empty;

			/// <summary>
			/// The height of this component in pixels (defaults to auto).
			/// </summary>
			[DefaultValue(typeof(Unit), "")]
			public override Unit Height 
			{ 
				get
				{
					return this.height;
				}
				set
				{
					this.height = value;
				}
			}

        }
    }
}