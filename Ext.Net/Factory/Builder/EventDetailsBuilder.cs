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
    public partial class EventDetails
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TEventDetails, TBuilder> : EventDetailsBase.Builder<TEventDetails, TBuilder>
            where TEventDetails : EventDetails
            where TBuilder : Builder<TEventDetails, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TEventDetails component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<EventDetailsListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<EventDetailsDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : EventDetails.Builder<EventDetails, EventDetails.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new EventDetails()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventDetails component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventDetails.Config config) : base(new EventDetails(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(EventDetails component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EventDetails(this);
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
        public EventDetails.Builder EventDetails()
        {
#if MVC
			return this.EventDetails(new EventDetails { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.EventDetails(new EventDetails());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder EventDetails(EventDetails component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new EventDetails.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EventDetails.Builder EventDetails(EventDetails.Config config)
        {
#if MVC
			return new EventDetails.Builder(new EventDetails(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new EventDetails.Builder(new EventDetails(config));
#endif			
        }
    }
}