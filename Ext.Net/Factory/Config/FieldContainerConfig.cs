/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class FieldContainer
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FieldContainer(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FieldContainer.Config Conversion to FieldContainer
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FieldContainer(FieldContainer.Config config)
        {
            return new FieldContainer(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : FieldContainerBase.Config 
        { 
			/*  Implicit FieldContainer.Config Conversion to FieldContainer.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FieldContainer.Builder(FieldContainer.Config config)
			{
				return new FieldContainer.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private FieldContainerListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public FieldContainerListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new FieldContainerListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private FieldContainerDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public FieldContainerDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new FieldContainerDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}