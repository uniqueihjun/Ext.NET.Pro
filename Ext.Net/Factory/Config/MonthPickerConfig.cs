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
    public partial class MonthPicker
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MonthPicker(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MonthPicker.Config Conversion to MonthPicker
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MonthPicker(MonthPicker.Config config)
        {
            return new MonthPicker(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ComponentBase.Config 
        { 
			/*  Implicit MonthPicker.Config Conversion to MonthPicker.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MonthPicker.Builder(MonthPicker.Config config)
			{
				return new MonthPicker.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string postBackEvent = "select";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("select")]
			public virtual string PostBackEvent 
			{ 
				get
				{
					return this.postBackEvent;
				}
				set
				{
					this.postBackEvent = value;
				}
			}

			private string cancelText = "";

			/// <summary>
			/// The text to display on the cancel button.
			/// </summary>
			[DefaultValue("")]
			public virtual string CancelText 
			{ 
				get
				{
					return this.cancelText;
				}
				set
				{
					this.cancelText = value;
				}
			}

			private string okText = "";

			/// <summary>
			/// The text to display on the ok button.
			/// </summary>
			[DefaultValue("")]
			public virtual string OkText 
			{ 
				get
				{
					return this.okText;
				}
				set
				{
					this.okText = value;
				}
			}

			private string selectedCls = "";

			/// <summary>
			/// The class to be added to selected items in the picker. Defaults to 'x-monthpicker-selected'
			/// </summary>
			[DefaultValue("")]
			public virtual string SelectedCls 
			{ 
				get
				{
					return this.selectedCls;
				}
				set
				{
					this.selectedCls = value;
				}
			}

			private bool showButtons = true;

			/// <summary>
			/// True to show ok and cancel buttons below the picker.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool ShowButtons 
			{ 
				get
				{
					return this.showButtons;
				}
				set
				{
					this.showButtons = value;
				}
			}

			private bool autoPostBack = false;

			/// <summary>
			/// AutoPostBack
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AutoPostBack 
			{ 
				get
				{
					return this.autoPostBack;
				}
				set
				{
					this.autoPostBack = value;
				}
			}

			private bool causesValidation = false;

			/// <summary>
			/// Gets or sets a value indicating whether validation is performed when the control is set to validate when a postback occurs.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool CausesValidation 
			{ 
				get
				{
					return this.causesValidation;
				}
				set
				{
					this.causesValidation = value;
				}
			}

			private string validationGroup = "";

			/// <summary>
			/// Gets or Sets the Controls ValidationGroup
			/// </summary>
			[DefaultValue("")]
			public virtual string ValidationGroup 
			{ 
				get
				{
					return this.validationGroup;
				}
				set
				{
					this.validationGroup = value;
				}
			}

			private DateTime? selectedDate = null;

			/// <summary>
			/// Gets or sets the current selected date of the MonthPicker. Accepts and returns a DateTime object.
			/// </summary>
			[DefaultValue(null)]
			public virtual DateTime? SelectedDate 
			{ 
				get
				{
					return this.selectedDate;
				}
				set
				{
					this.selectedDate = value;
				}
			}

			private int? selectedMonth = null;

			/// <summary>
			/// Selected month number
			/// </summary>
			[DefaultValue(null)]
			public virtual int? SelectedMonth 
			{ 
				get
				{
					return this.selectedMonth;
				}
				set
				{
					this.selectedMonth = value;
				}
			}

			private int? selectedYear = null;

			/// <summary>
			/// Selected year number
			/// </summary>
			[DefaultValue(null)]
			public virtual int? SelectedYear 
			{ 
				get
				{
					return this.selectedYear;
				}
				set
				{
					this.selectedYear = value;
				}
			}
        
			private MonthPickerListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public MonthPickerListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new MonthPickerListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private MonthPickerDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public MonthPickerDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new MonthPickerDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}