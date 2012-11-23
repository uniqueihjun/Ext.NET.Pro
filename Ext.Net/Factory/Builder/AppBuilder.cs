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
    public partial class App
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TApp, TBuilder> : XControllerBase.Builder<TApp, TBuilder>
            where TApp : App
            where TBuilder : Builder<TApp, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TApp component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Launch(Action<ItemsCollection<Observable>> action)
            {
                action(this.ToComponent().Launch);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// The name of your application. This will also be the namespace for your views, controllers models and stores. Don't use spaces or special characters in the name.
			/// </summary>
            public virtual TBuilder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : App.Builder<App, App.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new App()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(App component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(App.Config config) : base(new App(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(App component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.App(this);
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
        public App.Builder App()
        {
#if MVC
			return this.App(new App { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.App(new App());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder App(App component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new App.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder App(App.Config config)
        {
#if MVC
			return new App.Builder(new App(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new App.Builder(new App(config));
#endif			
        }
    }
}