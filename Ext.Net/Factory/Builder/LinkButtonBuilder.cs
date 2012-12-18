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
    public partial class LinkButton
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TLinkButton, TBuilder> : Button.Builder<TLinkButton, TBuilder>
            where TLinkButton : LinkButton
            where TBuilder : Builder<TLinkButton, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TLinkButton component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : LinkButton.Builder<LinkButton, LinkButton.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LinkButton()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LinkButton component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LinkButton.Config config) : base(new LinkButton(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LinkButton component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LinkButton(this);
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
        public LinkButton.Builder LinkButton()
        {
#if MVC
			return this.LinkButton(new LinkButton { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.LinkButton(new LinkButton());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder LinkButton(LinkButton component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new LinkButton.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LinkButton.Builder LinkButton(LinkButton.Config config)
        {
#if MVC
			return new LinkButton.Builder(new LinkButton(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new LinkButton.Builder(new LinkButton(config));
#endif			
        }
    }
}