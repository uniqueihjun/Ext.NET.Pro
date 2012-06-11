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
    public abstract partial class CheckboxBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCheckboxBase, TBuilder> : Field.Builder<TCheckboxBase, TBuilder>
            where TCheckboxBase : CheckboxBase
            where TBuilder : Builder<TCheckboxBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCheckboxBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The text that appears beside the checkbox (defaults to '').
			/// </summary>
            public virtual TBuilder BoxLabel(string boxLabel)
            {
                this.ToComponent().BoxLabel = boxLabel;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder BoxLabelStyle(string boxLabelStyle)
            {
                this.ToComponent().BoxLabelStyle = boxLabelStyle;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder BoxLabelCls(string boxLabelCls)
            {
                this.ToComponent().BoxLabelCls = boxLabelCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True if the checkbox should render already checked (defaults to false).
			/// </summary>
            public virtual TBuilder Checked(bool _checked)
            {
                this.ToComponent().Checked = _checked;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class to use when the control is checked (defaults to 'x-form-check-checked'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.
			/// </summary>
            public virtual TBuilder CheckedCls(string checkedCls)
            {
                this.ToComponent().CheckedCls = checkedCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class to use when the control receives input focus (defaults to 'x-form-check-focus'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.
			/// </summary>
            public virtual TBuilder FocusCls(string focusCls)
            {
                this.ToComponent().FocusCls = focusCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The value that should go into the generated input element's value attribute (defaults to undefined, with no value attribute)
			/// </summary>
            public virtual TBuilder InputValue(string inputValue)
            {
                this.ToComponent().InputValue = inputValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class to use when the control is being actively clicked (defaults to 'x-form-check-down'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.
			/// </summary>
            public virtual TBuilder MouseDownCls(string mouseDownCls)
            {
                this.ToComponent().MouseDownCls = mouseDownCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class to use when the control is hovered over (defaults to 'x-form-check-over'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.
			/// </summary>
            public virtual TBuilder OverCls(string overCls)
            {
                this.ToComponent().OverCls = overCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Tag(string tag)
            {
                this.ToComponent().Tag = tag;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}