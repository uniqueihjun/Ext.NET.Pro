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
    public partial class MvcItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TMvcItem, TBuilder> : AbstractComponent.Builder<TMvcItem, TBuilder>
            where TMvcItem : MvcItem
            where TBuilder : Builder<TMvcItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TMvcItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Expression(Func<System.Web.IHtmlString> expression)
            {
                this.ToComponent().Expression = expression;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : MvcItem.Builder<MvcItem, MvcItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new MvcItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MvcItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(MvcItem.Config config) : base(new MvcItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(MvcItem component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public MvcItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.MvcItem(this);
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
        public MvcItem.Builder MvcItem()
        {
#if MVC
			return this.MvcItem(new MvcItem { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.MvcItem(new MvcItem());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public MvcItem.Builder MvcItem(MvcItem component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new MvcItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public MvcItem.Builder MvcItem(MvcItem.Config config)
        {
#if MVC
			return new MvcItem.Builder(new MvcItem(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new MvcItem.Builder(new MvcItem(config));
#endif			
        }
    }
}