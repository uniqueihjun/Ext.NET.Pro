/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class Store
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StoreDataBound.Builder<Store, Store.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Store()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Store component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Store.Config config) : base(new Store(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Store component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(StoreListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(StoreDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Store.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Store(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Store.Builder Store()
        {
            return this.Store(new Store());
        }

        /// <summary>
        /// 
        /// </summary>
        public Store.Builder Store(Store component)
        {
            return new Store.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Store.Builder Store(Store.Config config)
        {
            return new Store.Builder(new Store(config));
        }
    }
}