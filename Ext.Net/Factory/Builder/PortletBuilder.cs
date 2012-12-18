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
    public partial class Portlet
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPortlet, TBuilder> : Panel.Builder<TPortlet, TBuilder>
            where TPortlet : Portlet
            where TBuilder : Builder<TPortlet, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPortlet component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Portlet.Builder<Portlet, Portlet.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Portlet()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portlet component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portlet.Config config) : base(new Portlet(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Portlet component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Portlet(this);
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
        public Portlet.Builder Portlet()
        {
#if MVC
			return this.Portlet(new Portlet { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Portlet(new Portlet());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder Portlet(Portlet component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Portlet.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Portlet.Builder Portlet(Portlet.Config config)
        {
#if MVC
			return new Portlet.Builder(new Portlet(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Portlet.Builder(new Portlet(config));
#endif			
        }
    }
}