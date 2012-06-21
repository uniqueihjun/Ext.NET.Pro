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
    public partial class Component
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Component(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Component.Config Conversion to Component
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Component(Component.Config config)
        {
            return new Component(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ComponentBase.Config 
        { 
			/*  Implicit Component.Config Conversion to Component.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Component.Builder(Component.Config config)
			{
				return new Component.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private AbstractComponentListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public AbstractComponentListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new AbstractComponentListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private AbstractComponentDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public AbstractComponentDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new AbstractComponentDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}