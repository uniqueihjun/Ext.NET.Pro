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
    public partial class UserControlLoader
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TUserControlLoader, TBuilder> : AbstractComponent.Builder<TUserControlLoader, TBuilder>
            where TUserControlLoader : UserControlLoader
            where TBuilder : Builder<TUserControlLoader, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TUserControlLoader component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Path(string path)
            {
                this.ToComponent().Path = path;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UserControlID(string userControlID)
            {
                this.ToComponent().UserControlID = userControlID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UserControlClientIDMode(ClientIDMode userControlClientIDMode)
            {
                this.ToComponent().UserControlClientIDMode = userControlClientIDMode;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : UserControlLoader.Builder<UserControlLoader, UserControlLoader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new UserControlLoader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UserControlLoader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UserControlLoader.Config config) : base(new UserControlLoader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(UserControlLoader component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.UserControlLoader(this);
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
        public UserControlLoader.Builder UserControlLoader()
        {
#if MVC
			return this.UserControlLoader(new UserControlLoader { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.UserControlLoader(new UserControlLoader());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder UserControlLoader(UserControlLoader component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new UserControlLoader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder UserControlLoader(UserControlLoader.Config config)
        {
#if MVC
			return new UserControlLoader.Builder(new UserControlLoader(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new UserControlLoader.Builder(new UserControlLoader(config));
#endif			
        }
    }
}