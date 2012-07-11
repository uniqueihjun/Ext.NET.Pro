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
    public partial class TextArea
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TextFieldBase.Builder<TextArea, TextArea.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TextArea()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TextArea component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TextArea.Config config) : base(new TextArea(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TextArea component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// An initial value for the 'cols' attribute on the textarea element. This is only used if the component has no configured width and is not given a width by its container's layout. Defaults to 4.
			/// </summary>
            public virtual TextArea.Builder Cols(int cols)
            {
                this.ToComponent().Cols = cols;
                return this as TextArea.Builder;
            }
             
 			/// <summary>
			/// True if you want the ENTER key to be classed as a special key and the specialkey event to be fired when ENTER is pressed. Defaults to: false
			/// </summary>
            public virtual TextArea.Builder EnterIsSpecial(bool enterIsSpecial)
            {
                this.ToComponent().EnterIsSpecial = enterIsSpecial;
                return this as TextArea.Builder;
            }
             
 			/// <summary>
			/// true to prevent scrollbars from appearing regardless of how much text is in the field. This option is only relevant when grow is true. Equivalent to setting overflow: hidden, defaults to false.
			/// </summary>
            public virtual TextArea.Builder PreventScrollbars(bool preventScrollbars)
            {
                this.ToComponent().PreventScrollbars = preventScrollbars;
                return this as TextArea.Builder;
            }
             
 			/// <summary>
			/// An initial value for the 'rows' attribute on the textarea element. This is only used if the component has no configured height and is not given a height by its container's layout. Defaults to 4.
			/// </summary>
            public virtual TextArea.Builder Rows(int rows)
            {
                this.ToComponent().Rows = rows;
                return this as TextArea.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TextArea.Builder</returns>
            public virtual TextArea.Builder Listeners(Action<TextFieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TextArea.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TextArea.Builder</returns>
            public virtual TextArea.Builder DirectEvents(Action<TextFieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TextArea.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TextArea.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TextArea(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TextArea.Builder TextArea()
        {
            return this.TextArea(new TextArea());
        }

        /// <summary>
        /// 
        /// </summary>
        public TextArea.Builder TextArea(TextArea component)
        {
            return new TextArea.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TextArea.Builder TextArea(TextArea.Config config)
        {
            return new TextArea.Builder(new TextArea(config));
        }
    }
}