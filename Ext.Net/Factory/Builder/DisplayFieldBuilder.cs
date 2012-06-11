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
    public partial class DisplayField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Field.Builder<DisplayField, DisplayField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DisplayField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DisplayField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DisplayField.Config config) : base(new DisplayField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DisplayField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to escape HTML in text when rendering it.
			/// </summary>
            public virtual DisplayField.Builder HtmlEncode(bool htmlEncode)
            {
                this.ToComponent().HtmlEncode = htmlEncode;
                return this as DisplayField.Builder;
            }
             
 			/// <summary>
			/// The plain text to display within the label (defaults to ''). If you need to include HTML tags within the label's innerHTML, use the html config instead.
			/// </summary>
            public virtual DisplayField.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as DisplayField.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DisplayField.Builder</returns>
            public virtual DisplayField.Builder Listeners(Action<FieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as DisplayField.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DisplayField.Builder</returns>
            public virtual DisplayField.Builder DirectEvents(Action<FieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as DisplayField.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DisplayField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DisplayField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayField.Builder DisplayField()
        {
            return this.DisplayField(new DisplayField());
        }

        /// <summary>
        /// 
        /// </summary>
        public DisplayField.Builder DisplayField(DisplayField component)
        {
            return new DisplayField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DisplayField.Builder DisplayField(DisplayField.Config config)
        {
            return new DisplayField.Builder(new DisplayField(config));
        }
    }
}