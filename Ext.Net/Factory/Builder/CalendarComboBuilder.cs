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
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCalendarCombo, TBuilder> : ComboBox.Builder<TCalendarCombo, TBuilder>
            where TCalendarCombo : CalendarCombo
            where TBuilder : Builder<TCalendarCombo, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCalendarCombo component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The calendar store ID to use.
			/// </summary>
            public virtual TBuilder CalendarStoreID(string calendarStoreID)
            {
                this.ToComponent().CalendarStoreID = calendarStoreID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The label text to display next to this Component (defaults to 'Calendar').
			/// </summary>
            public virtual TBuilder FieldLabel(string fieldLabel)
            {
                this.ToComponent().FieldLabel = fieldLabel;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The action to execute when the trigger field is activated. Use 'All' to run the query specified by the allQuery config option (defaults to 'All').
			/// </summary>
            public virtual TBuilder TriggerAction(TriggerAction triggerAction)
            {
                this.ToComponent().TriggerAction = triggerAction;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Set to 'local' if the ComboBox loads local data (defaults to 'Local' which loads from the server).
			/// </summary>
            public virtual TBuilder QueryMode(DataLoadMode queryMode)
            {
                this.ToComponent().QueryMode = queryMode;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// true to restrict the selected value to one of the values in the list, false to allow the user to set arbitrary text into the field (defaults to true)
			/// </summary>
            public virtual TBuilder ForceSelection(bool forceSelection)
            {
                this.ToComponent().ForceSelection = forceSelection;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to automatically select any existing field text when the field receives input focus (defaults to true).
			/// </summary>
            public virtual TBuilder SelectOnFocus(bool selectOnFocus)
            {
                this.ToComponent().SelectOnFocus = selectOnFocus;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CalendarCombo.Builder<CalendarCombo, CalendarCombo.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CalendarCombo(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
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
#if MVC
			return this.CalendarCombo(new CalendarCombo { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CalendarCombo(new CalendarCombo());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder CalendarCombo(CalendarCombo component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CalendarCombo.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CalendarCombo.Builder CalendarCombo(CalendarCombo.Config config)
        {
#if MVC
			return new CalendarCombo.Builder(new CalendarCombo(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CalendarCombo.Builder(new CalendarCombo(config));
#endif			
        }
    }
}