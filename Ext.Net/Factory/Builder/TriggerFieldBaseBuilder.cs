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
    public abstract partial class TriggerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TTriggerFieldBase, TBuilder> : TextFieldBase.Builder<TTriggerFieldBase, TBuilder>
            where TTriggerFieldBase : TriggerFieldBase
            where TBuilder : Builder<TTriggerFieldBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTriggerFieldBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Triggers(Action<FieldTrigerCollection> action)
            {
                action(this.ToComponent().Triggers);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// false to prevent the user from typing text directly into the field; the field can only have its value set via an action invoked by the trigger. (defaults to true).
			/// </summary>
            public virtual TBuilder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to hide the trigger element and display only the base text field (defaults to false).
			/// </summary>
            public virtual TBuilder HideTrigger(bool hideTrigger)
            {
                this.ToComponent().HideTrigger = hideTrigger;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to hide the predefined trigger element (defaults to false).
			/// </summary>
            public virtual TBuilder HideBaseTrigger(bool hideBaseTrigger)
            {
                this.ToComponent().HideBaseTrigger = hideBaseTrigger;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to show base trigger first
			/// </summary>
            public virtual TBuilder FirstBaseTrigger(bool firstBaseTrigger)
            {
                this.ToComponent().FirstBaseTrigger = firstBaseTrigger;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to attach a click repeater to the trigger. Defaults to false.
			/// </summary>
            public virtual TBuilder RepeatTriggerClick(bool repeatTriggerClick)
            {
                this.ToComponent().RepeatTriggerClick = repeatTriggerClick;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A CSS class to apply to the trigger.
			/// </summary>
            public virtual TBuilder TriggerCls(string triggerCls)
            {
                this.ToComponent().TriggerCls = triggerCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The icon to use in the trigger.
			/// </summary>
            public virtual TBuilder TriggerIcon(TriggerIcon triggerIcon)
            {
                this.ToComponent().TriggerIcon = triggerIcon;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Show a trigger
			/// </summary>
            public virtual TBuilder ShowTrigger(int index)
            {
                this.ToComponent().ShowTrigger(index);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Hide a trigger
			/// </summary>
            public virtual TBuilder ConcealTrigger(int index)
            {
                this.ToComponent().ConcealTrigger(index);
                return this as TBuilder;
            }
            
        }        
    }
}