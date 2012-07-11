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
    public partial class Store
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StoreBase.Builder<Store, Store.Builder>
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
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Store.Builder</returns>
            public virtual Store.Builder Listeners(Action<StoreListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Store.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Store.Builder</returns>
            public virtual Store.Builder DirectEvents(Action<StoreDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Store.Builder;
            }
			

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