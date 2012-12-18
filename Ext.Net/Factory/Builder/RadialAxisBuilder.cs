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
    public partial class RadialAxis
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRadialAxis, TBuilder> : AbstractAxis.Builder<TRadialAxis, TBuilder>
            where TRadialAxis : RadialAxis
            where TBuilder : Builder<TRadialAxis, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRadialAxis component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Steps(int steps)
            {
                this.ToComponent().Steps = steps;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Maximum(int maximum)
            {
                this.ToComponent().Maximum = maximum;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RadialAxis.Builder<RadialAxis, RadialAxis.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RadialAxis()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RadialAxis.Config config) : base(new RadialAxis(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RadialAxis component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RadialAxis(this);
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
        public RadialAxis.Builder RadialAxis()
        {
#if MVC
			return this.RadialAxis(new RadialAxis { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RadialAxis(new RadialAxis());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RadialAxis.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RadialAxis.Builder RadialAxis(RadialAxis.Config config)
        {
#if MVC
			return new RadialAxis.Builder(new RadialAxis(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RadialAxis.Builder(new RadialAxis(config));
#endif			
        }
    }
}