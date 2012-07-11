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
    public partial class CellEditing
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CellEditing(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CellEditing.Config Conversion to CellEditing
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CellEditing(CellEditing.Config config)
        {
            return new CellEditing(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridEditing.Config 
        { 
			/*  Implicit CellEditing.Config Conversion to CellEditing.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CellEditing.Builder(CellEditing.Config config)
			{
				return new CellEditing.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private CellEditingListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public CellEditingListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new CellEditingListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private CellEditingDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public CellEditingDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new CellEditingDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}