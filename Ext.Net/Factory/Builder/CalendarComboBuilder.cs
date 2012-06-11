/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComboBox.Builder<CalendarCombo, CalendarCombo.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CalendarCombo()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarCombo component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CalendarCombo.Config config) : base(new CalendarCombo(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CalendarCombo component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The calendar store ID to use.
			/// </summary>
            public virtual CalendarCombo.Builder CalendarStoreID(string calendarStoreID)
            {
                this.ToComponent().CalendarStoreID = calendarStoreID;
                return this as CalendarCombo.Builder;
            }
             
 			/// <summary>
			/// The label text to display next to this Component (defaults to 'Calendar').
			/// </summary>
            public virtual CalendarCombo.Builder FieldLabel(string fieldLabel)
            {
                this.ToComponent().FieldLabel = fieldLabel;
                return this as CalendarCombo.Builder;
            }
             
 			/// <summary>
			/// The action to execute when the trigger field is activated. Use 'All' to run the query specified by the allQuery config option (defaults to 'All').
			/// </summary>
            public virtual CalendarCombo.Builder TriggerAction(TriggerAction triggerAction)
            {
                this.ToComponent().TriggerAction = triggerAction;
                return this as CalendarCombo.Builder;
            }
             
 			/// <summary>
			/// Set to 'local' if the ComboBox loads local data (defaults to 'Local' which loads from the server).
			/// </summary>
            public virtual CalendarCombo.Builder QueryMode(DataLoadMode queryMode)
            {
                this.ToComponent().QueryMode = queryMode;
                return this as CalendarCombo.Builder;
            }
             
 			/// <summary>
			/// true to restrict the selected value to one of the values in the list, false to allow the user to set arbitrary text into the field (defaults to true)
			/// </summary>
            public virtual CalendarCombo.Builder ForceSelection(bool forceSelection)
            {
                this.ToComponent().ForceSelection = forceSelection;
                return this as CalendarCombo.Builder;
            }
             
 			/// <summary>
			/// True to automatically select any existing field text when the field receives input focus (defaults to true).
			/// </summary>
            public virtual CalendarCombo.Builder SelectOnFocus(bool selectOnFocus)
            {
                this.ToComponent().SelectOnFocus = selectOnFocus;
                return this as CalendarCombo.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarCombo(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder CalendarCombo()
        {
            return this.CalendarCombo(new CalendarCombo());
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder CalendarCombo(CalendarCombo component)
        {
            return new CalendarCombo.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder CalendarCombo(CalendarCombo.Config config)
        {
            return new CalendarCombo.Builder(new CalendarCombo(config));
        }
    }
}