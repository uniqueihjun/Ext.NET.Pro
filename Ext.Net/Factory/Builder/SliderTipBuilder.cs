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
    public partial class SliderTip
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSliderTip, TBuilder> : Plugin.Builder<TSliderTip, TBuilder>
            where TSliderTip : SliderTip
            where TBuilder : Builder<TSliderTip, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSliderTip component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : SliderTip.Builder<SliderTip, SliderTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SliderTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SliderTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SliderTip.Config config) : base(new SliderTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SliderTip component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public SliderTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SliderTip(this);
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
        public SliderTip.Builder SliderTip()
        {
#if MVC
			return this.SliderTip(new SliderTip { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.SliderTip(new SliderTip());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public SliderTip.Builder SliderTip(SliderTip component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new SliderTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SliderTip.Builder SliderTip(SliderTip.Config config)
        {
#if MVC
			return new SliderTip.Builder(new SliderTip(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new SliderTip.Builder(new SliderTip(config));
#endif			
        }
    }
}