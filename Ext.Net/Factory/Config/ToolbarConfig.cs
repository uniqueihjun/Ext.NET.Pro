/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class Toolbar
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Toolbar(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Toolbar.Config Conversion to Toolbar
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Toolbar(Toolbar.Config config)
        {
            return new Toolbar(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolbarBase.Config 
        { 
			/*  Implicit Toolbar.Config Conversion to Toolbar.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Toolbar.Builder(Toolbar.Config config)
			{
				return new Toolbar.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ToolbarListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ToolbarListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ToolbarListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ToolbarDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public ToolbarDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ToolbarDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}