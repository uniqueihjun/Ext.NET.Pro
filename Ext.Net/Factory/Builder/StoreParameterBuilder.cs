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
    public partial class StoreParameter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TStoreParameter, TBuilder> : Parameter.Builder<TStoreParameter, TBuilder>
            where TStoreParameter : StoreParameter
            where TBuilder : Builder<TStoreParameter, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TStoreParameter component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ApplyMode(ApplyMode applyMode)
            {
                this.ToComponent().ApplyMode = applyMode;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Action(StoreAction? action)
            {
                this.ToComponent().Action = action;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : StoreParameter.Builder<StoreParameter, StoreParameter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new StoreParameter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StoreParameter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(StoreParameter.Config config) : base(new StoreParameter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(StoreParameter component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.StoreParameter(this);
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
        public StoreParameter.Builder StoreParameter()
        {
#if MVC
			return this.StoreParameter(new StoreParameter { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.StoreParameter(new StoreParameter());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder StoreParameter(StoreParameter component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new StoreParameter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public StoreParameter.Builder StoreParameter(StoreParameter.Config config)
        {
#if MVC
			return new StoreParameter.Builder(new StoreParameter(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new StoreParameter.Builder(new StoreParameter(config));
#endif			
        }
    }
}