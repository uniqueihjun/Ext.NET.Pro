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
    public partial class DataViewAnimated
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDataViewAnimated, TBuilder> : Plugin.Builder<TDataViewAnimated, TBuilder>
            where TDataViewAnimated : DataViewAnimated
            where TBuilder : Builder<TDataViewAnimated, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDataViewAnimated component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Duration(int duration)
            {
                this.ToComponent().Duration = duration;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder IDProperty(string iDProperty)
            {
                this.ToComponent().IDProperty = iDProperty;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DataViewAnimated.Builder<DataViewAnimated, DataViewAnimated.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DataViewAnimated()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewAnimated component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DataViewAnimated.Config config) : base(new DataViewAnimated(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DataViewAnimated component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DataViewAnimated(this);
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
        public DataViewAnimated.Builder DataViewAnimated()
        {
#if MVC
			return this.DataViewAnimated(new DataViewAnimated { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DataViewAnimated(new DataViewAnimated());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder DataViewAnimated(DataViewAnimated component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DataViewAnimated.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DataViewAnimated.Builder DataViewAnimated(DataViewAnimated.Config config)
        {
#if MVC
			return new DataViewAnimated.Builder(new DataViewAnimated(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DataViewAnimated.Builder(new DataViewAnimated(config));
#endif			
        }
    }
}