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
    public partial class AreaSeries
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAreaSeries, TBuilder> : CartesianSeries.Builder<TAreaSeries, TBuilder>
            where TAreaSeries : AreaSeries
            where TBuilder : Builder<TAreaSeries, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAreaSeries component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Style(SpriteAttributes style)
            {
                this.ToComponent().Style = style;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : AreaSeries.Builder<AreaSeries, AreaSeries.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AreaSeries()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AreaSeries component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AreaSeries.Config config) : base(new AreaSeries(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AreaSeries component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AreaSeries(this);
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
        public AreaSeries.Builder AreaSeries()
        {
#if MVC
			return this.AreaSeries(new AreaSeries { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.AreaSeries(new AreaSeries());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder AreaSeries(AreaSeries component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new AreaSeries.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AreaSeries.Builder AreaSeries(AreaSeries.Config config)
        {
#if MVC
			return new AreaSeries.Builder(new AreaSeries(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new AreaSeries.Builder(new AreaSeries(config));
#endif			
        }
    }
}