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
    public partial class TriggerField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TriggerField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TriggerField.Config Conversion to TriggerField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TriggerField(TriggerField.Config config)
        {
            return new TriggerField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseTriggerField.Config 
        { 
			/*  Implicit TriggerField.Config Conversion to TriggerField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TriggerField.Builder(TriggerField.Config config)
			{
				return new TriggerField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private TriggerFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public TriggerFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new TriggerFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private TriggerFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public TriggerFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new TriggerFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}