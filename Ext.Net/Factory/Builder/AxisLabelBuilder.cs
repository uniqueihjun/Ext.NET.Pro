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
    public partial class AxisLabel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAxisLabel, TBuilder> : SpriteAttributes.Builder<TAxisLabel, TBuilder>
            where TAxisLabel : AxisLabel
            where TBuilder : Builder<TAxisLabel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAxisLabel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Renderer(Action<JFunction> action)
            {
                action(this.ToComponent().Renderer);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Padding(int? padding)
            {
                this.ToComponent().Padding = padding;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : AxisLabel.Builder<AxisLabel, AxisLabel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AxisLabel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisLabel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AxisLabel.Config config) : base(new AxisLabel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AxisLabel component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AxisLabel(this);
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
        public AxisLabel.Builder AxisLabel()
        {
#if MVC
			return this.AxisLabel(new AxisLabel { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.AxisLabel(new AxisLabel());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder AxisLabel(AxisLabel component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new AxisLabel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AxisLabel.Builder AxisLabel(AxisLabel.Config config)
        {
#if MVC
			return new AxisLabel.Builder(new AxisLabel(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new AxisLabel.Builder(new AxisLabel(config));
#endif			
        }
    }
}