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
    public partial class DrawBackground
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDrawBackground, TBuilder> : BaseItem.Builder<TDrawBackground, TBuilder>
            where TDrawBackground : DrawBackground
            where TBuilder : Builder<TDrawBackground, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDrawBackground component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The fill color
			/// </summary>
            public virtual TBuilder Fill(string fill)
            {
                this.ToComponent().Fill = fill;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The background image
			/// </summary>
            public virtual TBuilder Image(string image)
            {
                this.ToComponent().Image = image;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Gradient(Gradient gradient)
            {
                this.ToComponent().Gradient = gradient;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DrawBackground.Builder<DrawBackground, DrawBackground.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DrawBackground()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawBackground component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawBackground.Config config) : base(new DrawBackground(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DrawBackground component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DrawBackground(this);
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
        public DrawBackground.Builder DrawBackground()
        {
#if MVC
			return this.DrawBackground(new DrawBackground { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DrawBackground(new DrawBackground());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder DrawBackground(DrawBackground component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DrawBackground.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawBackground.Builder DrawBackground(DrawBackground.Config config)
        {
#if MVC
			return new DrawBackground.Builder(new DrawBackground(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DrawBackground.Builder(new DrawBackground(config));
#endif			
        }
    }
}