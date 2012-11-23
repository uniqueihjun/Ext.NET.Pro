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
    public partial class RowWrap
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TRowWrap, TBuilder> : GridFeature.Builder<TRowWrap, TBuilder>
            where TRowWrap : RowWrap
            where TBuilder : Builder<TRowWrap, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TRowWrap component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : RowWrap.Builder<RowWrap, RowWrap.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new RowWrap()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowWrap component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(RowWrap.Config config) : base(new RowWrap(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(RowWrap component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.RowWrap(this);
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
        public RowWrap.Builder RowWrap()
        {
#if MVC
			return this.RowWrap(new RowWrap { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.RowWrap(new RowWrap());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder RowWrap(RowWrap component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new RowWrap.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public RowWrap.Builder RowWrap(RowWrap.Config config)
        {
#if MVC
			return new RowWrap.Builder(new RowWrap(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new RowWrap.Builder(new RowWrap(config));
#endif			
        }
    }
}