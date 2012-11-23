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
    public partial class ModelStateStore
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TModelStateStore, TBuilder> : Store.Builder<TModelStateStore, TBuilder>
            where TModelStateStore : ModelStateStore
            where TBuilder : Builder<TModelStateStore, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TModelStateStore component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ModelStateStore.Builder<ModelStateStore, ModelStateStore.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ModelStateStore()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ModelStateStore component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ModelStateStore.Config config) : base(new ModelStateStore(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ModelStateStore component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelStateStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ModelStateStore(this);
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
        public ModelStateStore.Builder ModelStateStore()
        {
#if MVC
			return this.ModelStateStore(new ModelStateStore { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ModelStateStore(new ModelStateStore());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelStateStore.Builder ModelStateStore(ModelStateStore component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ModelStateStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelStateStore.Builder ModelStateStore(ModelStateStore.Config config)
        {
#if MVC
			return new ModelStateStore.Builder(new ModelStateStore(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ModelStateStore.Builder(new ModelStateStore(config));
#endif			
        }
    }
}