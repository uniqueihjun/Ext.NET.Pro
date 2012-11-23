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
    public partial class Summary
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TSummary, TBuilder> : AbstractSummary.Builder<TSummary, TBuilder>
            where TSummary : Summary
            where TBuilder : Builder<TSummary, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TSummary component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Summary.Builder<Summary, Summary.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Summary()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Summary component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Summary.Config config) : base(new Summary(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Summary component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Summary(this);
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
        public Summary.Builder Summary()
        {
#if MVC
			return this.Summary(new Summary { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Summary(new Summary());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder Summary(Summary component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Summary.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Summary.Builder Summary(Summary.Config config)
        {
#if MVC
			return new Summary.Builder(new Summary(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Summary.Builder(new Summary(config));
#endif			
        }
    }
}