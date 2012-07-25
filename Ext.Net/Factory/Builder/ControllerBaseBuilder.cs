/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public abstract partial class ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TControllerBase, TBuilder> : Observable.Builder<TControllerBase, TBuilder>
            where TControllerBase : ControllerBase
            where TBuilder : Builder<TControllerBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TControllerBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Array of models to require from AppName.model namespace.
			/// </summary>
            public virtual TBuilder Models(string[] models)
            {
                this.ToComponent().Models = models;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
            public virtual TBuilder Stores(string[] stores)
            {
                this.ToComponent().Stores = stores;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
            public virtual TBuilder Views(string[] views)
            {
                this.ToComponent().Views = views;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The controller name. Required
			/// </summary>
            public virtual TBuilder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}