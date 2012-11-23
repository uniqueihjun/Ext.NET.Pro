/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
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
			 
 			/// <summary>
			/// Allow users to deselect a record in a DataView, List or Grid. Only applicable when the SelectionModel's mode is 'SINGLE'. Defaults to false.
			/// </summary>
            public virtual TBuilder AllowDeselect(bool allowDeselect)
            {
                this.ToComponent().AllowDeselect = allowDeselect;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Prune records when they are removed from the store from the selection.
			/// </summary>
            public virtual TBuilder PruneRemoved(bool pruneRemoved)
            {
                this.ToComponent().PruneRemoved = pruneRemoved;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Modes of selection. Valid values are SINGLE, SIMPLE, and MULTI. Defaults to 'SINGLE'
			/// </summary>
            public virtual TBuilder Mode(SelectionMode mode)
            {
                this.ToComponent().Mode = mode;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}