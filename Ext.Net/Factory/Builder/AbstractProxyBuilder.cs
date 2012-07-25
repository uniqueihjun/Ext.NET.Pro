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
    public abstract partial class AbstractProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TAbstractProxy, TBuilder> : BaseItem.Builder<TAbstractProxy, TBuilder>
            where TAbstractProxy : AbstractProxy
            where TBuilder : Builder<TAbstractProxy, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractProxy component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to batch actions of a particular type when synchronizing the store. Defaults to true.
			/// </summary>
            public virtual TBuilder BatchActions(bool batchActions)
            {
                this.ToComponent().BatchActions = batchActions;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Comma-separated ordering 'create', 'update' and 'destroy' actions when batching. Override this to set a different order for the batched CRUD actions to be executed in. Defaults to 'create,update,destroy'
			/// </summary>
            public virtual TBuilder BatchOrder(string batchOrder)
            {
                this.ToComponent().BatchOrder = batchOrder;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}