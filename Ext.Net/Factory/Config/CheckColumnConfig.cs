/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class CheckColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CheckColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CheckColumn.Config Conversion to CheckColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CheckColumn(CheckColumn.Config config)
        {
            return new CheckColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ColumnBase.Config 
        { 
			/*  Implicit CheckColumn.Config Conversion to CheckColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CheckColumn.Builder(CheckColumn.Config config)
			{
				return new CheckColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool editable = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Editable 
			{ 
				get
				{
					return this.editable;
				}
				set
				{
					this.editable = value;
				}
			}

			private bool singleSelect = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool SingleSelect 
			{ 
				get
				{
					return this.singleSelect;
				}
				set
				{
					this.singleSelect = value;
				}
			}

			private bool stopSelection = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool StopSelection 
			{ 
				get
				{
					return this.stopSelection;
				}
				set
				{
					this.stopSelection = value;
				}
			}
        
			private CheckColumnListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public CheckColumnListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new CheckColumnListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private CheckColumnDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public CheckColumnDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new CheckColumnDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}