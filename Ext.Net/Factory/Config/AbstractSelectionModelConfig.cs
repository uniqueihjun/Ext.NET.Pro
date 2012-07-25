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
    public abstract partial class AbstractSelectionModel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : LazyObservable.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool allowDeselect = false;

			/// <summary>
			/// Allow users to deselect a record in a DataView, List or Grid. Only applicable when the SelectionModel's mode is 'SINGLE'. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowDeselect 
			{ 
				get
				{
					return this.allowDeselect;
				}
				set
				{
					this.allowDeselect = value;
				}
			}

			private bool pruneRemoved = true;

			/// <summary>
			/// Prune records when they are removed from the store from the selection.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool PruneRemoved 
			{ 
				get
				{
					return this.pruneRemoved;
				}
				set
				{
					this.pruneRemoved = value;
				}
			}

			private SelectionMode mode = SelectionMode.Single;

			/// <summary>
			/// Modes of selection. Valid values are SINGLE, SIMPLE, and MULTI. Defaults to 'SINGLE'
			/// </summary>
			[DefaultValue(SelectionMode.Single)]
			public virtual SelectionMode Mode 
			{ 
				get
				{
					return this.mode;
				}
				set
				{
					this.mode = value;
				}
			}

        }
    }
}