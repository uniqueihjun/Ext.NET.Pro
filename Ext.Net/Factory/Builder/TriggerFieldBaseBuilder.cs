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
    public abstract partial class TriggerFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTriggerFieldBase, TBuilder> : TextFieldBase.Builder<TTriggerFieldBase, TBuilder>
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
			 
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder Triggers(FieldTrigerCollection triggers)
            // {
            //    this.ToComponent().Triggers = triggers;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// True to hide the trigger element and display only the base text field (defaults to false).
			/// </summary>
            public virtual TBuilder HideTrigger(bool hideTrigger)
            {
                this.ToComponent().HideTrigger = hideTrigger;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// False to prevent the user from typing text directly into the field, the field will only respond to a click on the trigger to set the value. (defaults to true).
			/// </summary>
            public virtual TBuilder Editable(bool editable)
            {
                this.ToComponent().Editable = editable;
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
			/// A CSS class to apply to the trigger.
			/// </summary>
            public virtual TBuilder TriggerClass(string triggerClass)
            {
                this.ToComponent().TriggerClass = triggerClass;
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