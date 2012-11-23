/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
        new public abstract partial class Builder<TImageButton, TBuilder> : Button.Builder<TImageButton, TBuilder>
            where TImageButton : ImageButton
            where TBuilder : Builder<TImageButton, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TImageButton component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ImageUrl(string imageUrl)
            {
                this.ToComponent().ImageUrl = imageUrl;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder OverImageUrl(string overImageUrl)
            {
                this.ToComponent().OverImageUrl = overImageUrl;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DisabledImageUrl(string disabledImageUrl)
            {
                this.ToComponent().DisabledImageUrl = disabledImageUrl;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder PressedImageUrl(string pressedImageUrl)
            {
                this.ToComponent().PressedImageUrl = pressedImageUrl;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AlternateText(string alternateText)
            {
                this.ToComponent().AlternateText = alternateText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Align(ImageAlign align)
            {
                this.ToComponent().Align = align;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ImageButton.Builder<ImageButton, ImageButton.Builder>
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
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ImageButton(this);
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
        public ImageButton.Builder ImageButton()
        {
#if MVC
			return this.ImageButton(new ImageButton { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ImageButton(new ImageButton());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ImageButton(ImageButton component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ImageButton.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageButton.Builder ImageButton(ImageButton.Config config)
        {
#if MVC
			return new ImageButton.Builder(new ImageButton(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ImageButton.Builder(new ImageButton(config));
#endif			
        }
    }
}