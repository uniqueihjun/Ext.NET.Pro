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
    public partial class ReminderCombo
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ReminderCombo(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ReminderCombo.Config Conversion to ReminderCombo
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReminderCombo(ReminderCombo.Config config)
        {
            return new ReminderCombo(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ComboBox.Config 
        { 
			/*  Implicit ReminderCombo.Config Conversion to ReminderCombo.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ReminderCombo.Builder(ReminderCombo.Config config)
			{
				return new ReminderCombo.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string fieldLabel = "Reminder";

			/// <summary>
			/// The label text to display next to this Component (defaults to 'Reminder').
			/// </summary>
			[DefaultValue("Reminder")]
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

			private string displayField = "desc";

			/// <summary>
			/// The underlying data field name to bind to this ComboBox (defaults to 'desc').
			/// </summary>
			[DefaultValue("desc")]
			public override string DisplayField 
			{ 
				get
				{
					return this.displayField;
				}
				set
				{
					this.displayField = value;
				}
			}

			private string valueField = "value";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("value")]
			public override string ValueField 
			{ 
				get
				{
					return this.valueField;
				}
				set
				{
					this.valueField = value;
				}
			}

        }
    }
}