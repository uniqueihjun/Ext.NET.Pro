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
    public partial class ObjectHolder
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TObjectHolder, TBuilder> : Observable.Builder<TObjectHolder, TBuilder>
            where TObjectHolder : ObjectHolder
            where TBuilder : Builder<TObjectHolder, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TObjectHolder component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Items(Action<JsonObject> action)
            {
                action(this.ToComponent().Items);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder UpdateData()
            {
                this.ToComponent().UpdateData();
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ObjectHolder.Builder<ObjectHolder, ObjectHolder.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ObjectHolder()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ObjectHolder component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ObjectHolder.Config config) : base(new ObjectHolder(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ObjectHolder component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ObjectHolder(this);
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
        public ObjectHolder.Builder ObjectHolder()
        {
#if MVC
			return this.ObjectHolder(new ObjectHolder { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ObjectHolder(new ObjectHolder());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ObjectHolder(ObjectHolder component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ObjectHolder.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder.Builder ObjectHolder(ObjectHolder.Config config)
        {
#if MVC
			return new ObjectHolder.Builder(new ObjectHolder(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ObjectHolder.Builder(new ObjectHolder(config));
#endif			
        }
    }
}