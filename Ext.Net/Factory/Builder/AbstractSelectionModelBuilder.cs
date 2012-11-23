/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public abstract partial class AbstractSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TAbstractSelectionModel, TBuilder> : LazyObservable.Builder<TAbstractSelectionModel, TBuilder>
            where TAbstractSelectionModel : AbstractSelectionModel
            where TBuilder : Builder<TAbstractSelectionModel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TAbstractSelectionModel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// Locks the selections.
			/// </summary>
            public virtual TBuilder Lock()
            {
                this.ToComponent().Lock();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Unlocks the selections.
			/// </summary>
            public virtual TBuilder Unlock()
            {
                this.ToComponent().Unlock();
                return this as TBuilder;
            }
            
        }        
    }
}