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
    public partial class FieldSet
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractContainer.Builder<FieldSet, FieldSet.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new FieldSet()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldSet component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(FieldSet.Config config) : base(new FieldSet(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(FieldSet component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The name to assign to the fieldset's checkbox if checkboxToggle = true (defaults to '[fieldset id]-checkbox').
			/// </summary>
            public virtual FieldSet.Builder CheckboxName(string checkboxName)
            {
                this.ToComponent().CheckboxName = checkboxName;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// Set to true to render a checkbox into the fieldset frame just in front of the legend to expand/collapse the fieldset when the checkbox is toggled. (defaults to false). This checkbox will be included in form submits using the checkboxName.
			/// </summary>
            public virtual FieldSet.Builder CheckboxToggle(bool checkboxToggle)
            {
                this.ToComponent().CheckboxToggle = checkboxToggle;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// Set to true to render the fieldset as collapsed by default. If checkboxToggle is specified, the checkbox will also be unchecked by default.
			/// </summary>
            public virtual FieldSet.Builder Collapsed(bool collapsed)
            {
                this.ToComponent().Collapsed = collapsed;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// Set to true to make the fieldset collapsible and have the expand/collapse toggle button automatically rendered into the legend element, false to keep the fieldset statically sized with no collapse button (defaults to false). Another option is to configure checkboxToggle. Use the collapsed config to collapse the fieldset by default.
			/// </summary>
            public virtual FieldSet.Builder Collapsible(bool collapsible)
            {
                this.ToComponent().Collapsible = collapsible;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// A title to be displayed in the fieldset's legend. May contain HTML markup.
			/// </summary>
            public virtual FieldSet.Builder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// Set to true will add a listener to the titleCmp property for the click event which will execute the toggle method. This option is only used when the collapsible property is set to true. Defaults to: true
			/// </summary>
            public virtual FieldSet.Builder ToggleOnTitleClick(bool toggleOnTitleClick)
            {
                this.ToComponent().ToggleOnTitleClick = toggleOnTitleClick;
                return this as FieldSet.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FieldSet.Builder</returns>
            public virtual FieldSet.Builder Listeners(Action<FieldSetListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as FieldSet.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of FieldSet.Builder</returns>
            public virtual FieldSet.Builder DirectEvents(Action<FieldSetDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as FieldSet.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldSet.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.FieldSet(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public FieldSet.Builder FieldSet()
        {
            return this.FieldSet(new FieldSet());
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldSet.Builder FieldSet(FieldSet component)
        {
            return new FieldSet.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public FieldSet.Builder FieldSet(FieldSet.Config config)
        {
            return new FieldSet.Builder(new FieldSet(config));
        }
    }
}