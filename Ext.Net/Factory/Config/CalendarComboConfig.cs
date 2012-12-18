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
    public partial class CalendarCombo
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CalendarCombo.Config Conversion to CalendarCombo
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CalendarCombo(CalendarCombo.Config config)
        {
            return new CalendarCombo(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ComboBox.Config 
        { 
			/*  Implicit CalendarCombo.Config Conversion to CalendarCombo.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CalendarCombo.Builder(CalendarCombo.Config config)
			{
				return new CalendarCombo.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
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

			private string fieldLabel = "Calendar";

			/// <summary>
			/// The label text to display next to this Component (defaults to 'Calendar').
			/// </summary>
			[DefaultValue("Calendar")]
			public override string FieldLabel 
			{ 
				get
				{
					return this.fieldLabel;
				}
				set
				{
					this.fieldLabel = value;
				}
			}

			private TriggerAction triggerAction = TriggerAction.All;

			/// <summary>
			/// The action to execute when the trigger field is activated. Use 'All' to run the query specified by the allQuery config option (defaults to 'All').
			/// </summary>
			[DefaultValue(TriggerAction.All)]
			public override TriggerAction TriggerAction 
			{ 
				get
				{
					return this.triggerAction;
				}
				set
				{
					this.triggerAction = value;
				}
			}

			private DataLoadMode queryMode = DataLoadMode.Local;

			/// <summary>
			/// Set to 'local' if the ComboBox loads local data (defaults to 'Local' which loads from the server).
			/// </summary>
			[DefaultValue(DataLoadMode.Local)]
			public override DataLoadMode QueryMode 
			{ 
				get
				{
					return this.queryMode;
				}
				set
				{
					this.queryMode = value;
				}
			}

			private bool forceSelection = true;

			/// <summary>
			/// true to restrict the selected value to one of the values in the list, false to allow the user to set arbitrary text into the field (defaults to true)
			/// </summary>
			[DefaultValue(true)]
			public override bool ForceSelection 
			{ 
				get
				{
					return this.forceSelection;
				}
				set
				{
					this.forceSelection = value;
				}
			}

			private bool selectOnFocus = true;

			/// <summary>
			/// True to automatically select any existing field text when the field receives input focus (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public override bool SelectOnFocus 
			{ 
				get
				{
					return this.selectOnFocus;
				}
				set
				{
					this.selectOnFocus = value;
				}
			}

        }
    }
}