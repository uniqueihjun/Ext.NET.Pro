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
    public partial class ImageButton
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Button.Builder<ImageButton, ImageButton.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ImageButton()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageButton component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ImageButton.Config config) : base(new ImageButton(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ImageButton component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder ImageUrl(string imageUrl)
            {
                this.ToComponent().ImageUrl = imageUrl;
                return this as ImageButton.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder OverImageUrl(string overImageUrl)
            {
                this.ToComponent().OverImageUrl = overImageUrl;
                return this as ImageButton.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder DisabledImageUrl(string disabledImageUrl)
            {
                this.ToComponent().DisabledImageUrl = disabledImageUrl;
                return this as ImageButton.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder PressedImageUrl(string pressedImageUrl)
            {
                this.ToComponent().PressedImageUrl = pressedImageUrl;
                return this as ImageButton.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder AlternateText(string alternateText)
            {
                this.ToComponent().AlternateText = alternateText;
                return this as ImageButton.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ImageButton.Builder Align(ImageAlign align)
            {
                this.ToComponent().Align = align;
                return this as ImageButton.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ImageButton(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ImageButton()
        {
            return this.ImageButton(new ImageButton());
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ImageButton(ImageButton component)
        {
            return new ImageButton.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ImageButton(ImageButton.Config config)
        {
            return new ImageButton.Builder(new ImageButton(config));
        }
    }
}