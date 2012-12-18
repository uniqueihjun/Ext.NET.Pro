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
    public partial class GradientStop
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGradientStop, TBuilder> : BaseItem.Builder<TGradientStop, TBuilder>
            where TGradientStop : GradientStop
            where TBuilder : Builder<TGradientStop, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGradientStop component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// (from 0 to 100)
			/// </summary>
            public virtual TBuilder Offset(int offset)
            {
                this.ToComponent().Offset = offset;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Color(string color)
            {
                this.ToComponent().Color = color;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Opacity(double opacity)
            {
                this.ToComponent().Opacity = opacity;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GradientStop.Builder<GradientStop, GradientStop.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GradientStop()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GradientStop component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GradientStop.Config config) : base(new GradientStop(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GradientStop component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GradientStop(this);
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
        public GradientStop.Builder GradientStop()
        {
#if MVC
			return this.GradientStop(new GradientStop { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GradientStop(new GradientStop());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder GradientStop(GradientStop component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GradientStop.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GradientStop.Builder GradientStop(GradientStop.Config config)
        {
#if MVC
			return new GradientStop.Builder(new GradientStop(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GradientStop.Builder(new GradientStop(config));
#endif			
        }
    }
}