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
    public partial class DrawText
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DrawComponent.Builder<DrawText, DrawText.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DrawText()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawText component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawText.Config config) : base(new DrawText(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DrawText component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Turn on autoSize support which will set the bounding div's size to the natural size of the contents. Defaults to true.
			/// </summary>
            public virtual DrawText.Builder AutoSize(bool autoSize)
            {
                this.ToComponent().AutoSize = autoSize;
                return this as DrawText.Builder;
            }
             
 			/// <summary>
			/// The angle by which to initially rotate the text clockwise. Defaults to zero.
			/// </summary>
            public virtual DrawText.Builder Degrees(int degrees)
            {
                this.ToComponent().Degrees = degrees;
                return this as DrawText.Builder;
            }
             
 			/// <summary>
			/// A CSS selector string which matches a style rule in the document stylesheet from which the text's font properties are read.
			/// </summary>
            public virtual DrawText.Builder StyleSelector(string styleSelector)
            {
                this.ToComponent().StyleSelector = styleSelector;
                return this as DrawText.Builder;
            }
             
 			/// <summary>
			/// The text to display (html tags are not accepted)
			/// </summary>
            public virtual DrawText.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as DrawText.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DrawText.Builder TextStyle(SpriteAttributes textStyle)
            {
                this.ToComponent().TextStyle = textStyle;
                return this as DrawText.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawText.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DrawText(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawText.Builder DrawText()
        {
            return this.DrawText(new DrawText());
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawText.Builder DrawText(DrawText component)
        {
            return new DrawText.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawText.Builder DrawText(DrawText.Config config)
        {
            return new DrawText.Builder(new DrawText(config));
        }
    }
}