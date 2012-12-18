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
    public partial class AppInit
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAppInit, TBuilder> : BaseItem.Builder<TAppInit, TBuilder>
            where TAppInit : AppInit
            where TBuilder : Builder<TAppInit, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAppInit component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// False to deactivate auto start of init script
			/// </summary>
            public virtual TBuilder AutoInit(bool autoInit)
            {
                this.ToComponent().AutoInit = autoInit;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder InitFnName(string initFnName)
            {
                this.ToComponent().InitFnName = initFnName;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : AppInit.Builder<AppInit, AppInit.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new AppInit()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AppInit component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(AppInit.Config config) : base(new AppInit(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(AppInit component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AppInit.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.AppInit(this);
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
        public AppInit.Builder AppInit()
        {
#if MVC
			return this.AppInit(new AppInit { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.AppInit(new AppInit());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public AppInit.Builder AppInit(AppInit component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new AppInit.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public AppInit.Builder AppInit(AppInit.Config config)
        {
#if MVC
			return new AppInit.Builder(new AppInit(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new AppInit.Builder(new AppInit(config));
#endif			
        }
    }
}