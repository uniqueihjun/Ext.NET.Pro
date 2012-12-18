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
    public partial class Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TParameter, TBuilder> : BaseParameter.Builder<TParameter, TBuilder>
            where TParameter : Parameter
            where TBuilder : Builder<TParameter, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TParameter component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Parameter.Builder<Parameter, Parameter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Parameter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Parameter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Parameter.Config config) : base(new Parameter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Parameter component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Parameter(this);
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
        public Parameter.Builder Parameter()
        {
#if MVC
			return this.Parameter(new Parameter { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Parameter(new Parameter());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder Parameter(Parameter component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Parameter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameter.Builder Parameter(Parameter.Config config)
        {
#if MVC
			return new Parameter.Builder(new Parameter(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Parameter.Builder(new Parameter(config));
#endif			
        }
    }
}