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
    public partial class ToolbarFill
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TToolbarFill, TBuilder> : ComponentBase.Builder<TToolbarFill, TBuilder>
            where TToolbarFill : ToolbarFill
            where TBuilder : Builder<TToolbarFill, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TToolbarFill component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarFill.Builder<ToolbarFill, ToolbarFill.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarFill()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill.Config config) : base(new ToolbarFill(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarFill component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarFill(this);
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
        public ToolbarFill.Builder ToolbarFill()
        {
#if MVC
			return this.ToolbarFill(new ToolbarFill { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ToolbarFill(new ToolbarFill());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ToolbarFill.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill.Config config)
        {
#if MVC
			return new ToolbarFill.Builder(new ToolbarFill(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ToolbarFill.Builder(new ToolbarFill(config));
#endif			
        }
    }
}