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
    public partial class DD
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDD, TBuilder> : DragDrop.Builder<TDD, TBuilder>
            where TDD : DD
            where TBuilder : Builder<TDD, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDD component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// When set to true, the utility automatically tries to scroll the browser window when a drag and drop element is dragged near the viewport boundary. Defaults to true.
			/// </summary>
            public virtual TBuilder Scroll(bool scroll)
            {
                this.ToComponent().Scroll = scroll;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DD.Builder<DD, DD.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DD()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DD component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DD.Config config) : base(new DD(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DD component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DD(this);
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
        public DD.Builder DD()
        {
#if MVC
			return this.DD(new DD { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DD(new DD());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder DD(DD component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DD.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DD.Builder DD(DD.Config config)
        {
#if MVC
			return new DD.Builder(new DD(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DD.Builder(new DD(config));
#endif			
        }
    }
}