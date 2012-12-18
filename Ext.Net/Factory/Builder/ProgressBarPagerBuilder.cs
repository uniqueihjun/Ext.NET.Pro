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
    public partial class ProgressBarPager
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TProgressBarPager, TBuilder> : Plugin.Builder<TProgressBarPager, TBuilder>
            where TProgressBarPager : ProgressBarPager
            where TBuilder : Builder<TProgressBarPager, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TProgressBarPager component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ProgressBarPager.Builder<ProgressBarPager, ProgressBarPager.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ProgressBarPager()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ProgressBarPager component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ProgressBarPager.Config config) : base(new ProgressBarPager(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ProgressBarPager component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ProgressBarPager(this);
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
        public ProgressBarPager.Builder ProgressBarPager()
        {
#if MVC
			return this.ProgressBarPager(new ProgressBarPager { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ProgressBarPager(new ProgressBarPager());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ProgressBarPager(ProgressBarPager component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ProgressBarPager.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ProgressBarPager.Builder ProgressBarPager(ProgressBarPager.Config config)
        {
#if MVC
			return new ProgressBarPager.Builder(new ProgressBarPager(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ProgressBarPager.Builder(new ProgressBarPager(config));
#endif			
        }
    }
}