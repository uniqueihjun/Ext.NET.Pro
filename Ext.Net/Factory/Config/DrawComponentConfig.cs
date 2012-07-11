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
    public partial class DrawComponent
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DrawComponent(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DrawComponent.Config Conversion to DrawComponent
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DrawComponent(DrawComponent.Config config)
        {
            return new DrawComponent(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractDrawComponent.Config 
        { 
			/*  Implicit DrawComponent.Config Conversion to DrawComponent.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DrawComponent.Builder(DrawComponent.Config config)
			{
				return new DrawComponent.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private DrawComponentListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DrawComponentListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DrawComponentListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DrawComponentDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public DrawComponentDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DrawComponentDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}