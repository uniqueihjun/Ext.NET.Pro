/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
        public partial class Builder : Store.Builder<EventStore, EventStore.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventStore.Builder</returns>
            public virtual EventStore.Builder Events(Action<EventModelCollection> action)
            {
                action(this.ToComponent().Events);
                return this as EventStore.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual EventStore.Builder NoMappings(bool noMappings)
            {
                this.ToComponent().NoMappings = noMappings;
                return this as EventStore.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of EventStore.Builder</returns>
            public virtual EventStore.Builder Mappings(Action<ModelFieldCollection> action)
            {
                action(this.ToComponent().Mappings);
                return this as EventStore.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.EventStore(this);
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
            return this.EventStore(new EventStore());
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder EventStore(EventStore component)
        {
            return new EventStore.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public EventStore.Builder EventStore(EventStore.Config config)
        {
            return new EventStore.Builder(new EventStore(config));
        }
    }
}