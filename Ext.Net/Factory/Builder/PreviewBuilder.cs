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
    public partial class Preview
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPreview, TBuilder> : Plugin.Builder<TPreview, TBuilder>
            where TPreview : Preview
            where TBuilder : Builder<TPreview, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPreview component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Preview.Builder<Preview, Preview.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Preview()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Preview component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Preview.Config config) : base(new Preview(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Preview component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Preview(this);
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
        public Preview.Builder Preview()
        {
#if MVC
			return this.Preview(new Preview { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Preview(new Preview());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder Preview(Preview component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Preview.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Preview.Builder Preview(Preview.Config config)
        {
#if MVC
			return new Preview.Builder(new Preview(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Preview.Builder(new Preview(config));
#endif			
        }
    }
}