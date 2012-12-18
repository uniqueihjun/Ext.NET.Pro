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
    public partial class TrayClock
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTrayClock, TBuilder> : ToolbarTextItem.Builder<TTrayClock, TBuilder>
            where TTrayClock : TrayClock
            where TBuilder : Builder<TTrayClock, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTrayClock component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder TimeFormat(string timeFormat)
            {
                this.ToComponent().TimeFormat = timeFormat;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Template(string template)
            {
                this.ToComponent().Template = template;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RefreshInterval(int refreshInterval)
            {
                this.ToComponent().RefreshInterval = refreshInterval;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : TrayClock.Builder<TrayClock, TrayClock.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TrayClock()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TrayClock component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TrayClock.Config config) : base(new TrayClock(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TrayClock component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TrayClock(this);
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
        public TrayClock.Builder TrayClock()
        {
#if MVC
			return this.TrayClock(new TrayClock { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.TrayClock(new TrayClock());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder TrayClock(TrayClock component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new TrayClock.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TrayClock.Builder TrayClock(TrayClock.Config config)
        {
#if MVC
			return new TrayClock.Builder(new TrayClock(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new TrayClock.Builder(new TrayClock(config));
#endif			
        }
    }
}