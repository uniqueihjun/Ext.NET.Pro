/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public abstract partial class TriggerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : TextFieldBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private FieldTrigerCollection triggers = null;

			/// <summary>
			/// 
			/// </summary>
			public FieldTrigerCollection Triggers
			{
				get
				{
					if (this.triggers == null)
					{
						this.triggers = new FieldTrigerCollection();
					}
			
					return this.triggers;
				}
			}
			
			private bool editable = true;

			/// <summary>
			/// false to prevent the user from typing text directly into the field; the field can only have its value set via an action invoked by the trigger. (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Editable 
			{ 
				get
				{
					return this.editable;
				}
				set
				{
					this.editable = value;
				}
			}

			private bool hideTrigger = false;

			/// <summary>
			/// True to hide the trigger element and display only the base text field (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideTrigger 
			{ 
				get
				{
					return this.hideTrigger;
				}
				set
				{
					this.hideTrigger = value;
				}
			}

			private bool hideBaseTrigger = false;

			/// <summary>
			/// True to hide the predefined trigger element (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideBaseTrigger 
			{ 
				get
				{
					return this.hideBaseTrigger;
				}
				set
				{
					this.hideBaseTrigger = value;
				}
			}

			private bool firstBaseTrigger = false;

			/// <summary>
			/// True to show base trigger first
			/// </summary>
			[DefaultValue(false)]
			public virtual bool FirstBaseTrigger 
			{ 
				get
				{
					return this.firstBaseTrigger;
				}
				set
				{
					this.firstBaseTrigger = value;
				}
			}

			private bool repeatTriggerClick = false;

			/// <summary>
			/// True to attach a click repeater to the trigger. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RepeatTriggerClick 
			{ 
				get
				{
					return this.repeatTriggerClick;
				}
				set
				{
					this.repeatTriggerClick = value;
				}
			}

			private string triggerCls = "";

			/// <summary>
			/// A CSS class to apply to the trigger.
			/// </summary>
			[DefaultValue("")]
			public virtual string TriggerCls 
			{ 
				get
				{
					return this.triggerCls;
				}
				set
				{
					this.triggerCls = value;
				}
			}

			private TriggerIcon triggerIcon = Net.TriggerIcon.Combo;

			/// <summary>
			/// The icon to use in the trigger.
			/// </summary>
			[DefaultValue(Net.TriggerIcon.Combo)]
			public virtual TriggerIcon TriggerIcon 
			{ 
				get
				{
					return this.triggerIcon;
				}
				set
				{
					this.triggerIcon = value;
				}
			}

        }
    }
}