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
    public partial class EventStore
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TEventStore, TBuilder> : Store.Builder<TEventStore, TBuilder>
            where TEventStore : EventStore
            where TBuilder : Builder<TEventStore, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TEventStore component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Events(Action<EventModelCollection> action)
            {
                action(this.ToComponent().Events);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder NoMappings(bool noMappings)
            {
                this.ToComponent().NoMappings = noMappings;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Mappings(Action<ModelFieldCollection> action)
            {
                action(this.ToComponent().Mappings);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : EventStore.Builder<EventStore, EventStore.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new EventStore()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventStore component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(EventStore.Config config) : base(new EventStore(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(EventStore component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EventStore(this);
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
        public EventStore.Builder EventStore()
        {
#if MVC
			return this.EventStore(new EventStore { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.EventStore(new EventStore());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder EventStore(EventStore component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new EventStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder EventStore(EventStore.Config config)
        {
#if MVC
			return new EventStore.Builder(new EventStore(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new EventStore.Builder(new EventStore(config));
#endif			
        }
    }
}