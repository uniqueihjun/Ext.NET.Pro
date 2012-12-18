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
    public partial class CRUDUrls
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCRUDUrls, TBuilder> : BaseItem.Builder<TCRUDUrls, TBuilder>
            where TCRUDUrls : CRUDUrls
            where TBuilder : Builder<TCRUDUrls, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCRUDUrls component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Sync(string sync)
            {
                this.ToComponent().Sync = sync;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Create(string create)
            {
                this.ToComponent().Create = create;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Read(string read)
            {
                this.ToComponent().Read = read;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Update(string update)
            {
                this.ToComponent().Update = update;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Destroy(string destroy)
            {
                this.ToComponent().Destroy = destroy;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CRUDUrls.Builder<CRUDUrls, CRUDUrls.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CRUDUrls()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CRUDUrls component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CRUDUrls.Config config) : base(new CRUDUrls(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CRUDUrls component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDUrls.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CRUDUrls(this);
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
        public CRUDUrls.Builder CRUDUrls()
        {
#if MVC
			return this.CRUDUrls(new CRUDUrls { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CRUDUrls(new CRUDUrls());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDUrls.Builder CRUDUrls(CRUDUrls component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CRUDUrls.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CRUDUrls.Builder CRUDUrls(CRUDUrls.Config config)
        {
#if MVC
			return new CRUDUrls.Builder(new CRUDUrls(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CRUDUrls.Builder(new CRUDUrls(config));
#endif			
        }
    }
}