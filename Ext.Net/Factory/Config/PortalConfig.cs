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
    public partial class Portal
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Portal(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Portal.Config Conversion to Portal
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Portal(Portal.Config config)
        {
            return new Portal(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractPanel.Config 
        { 
			/*  Implicit Portal.Config Conversion to Portal.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Portal.Builder(Portal.Config config)
			{
				return new Portal.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private PortalListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public PortalListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new PortalListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private PortalDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEvent Handlers
			/// </summary>
			public PortalDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new PortalDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
			private bool autoScroll = true;

			/// <summary>
			/// true to use overflow:'auto' on the components layout element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).
			/// </summary>
			[DefaultValue(true)]
			public override bool AutoScroll 
			{ 
				get
				{
					return this.autoScroll;
				}
				set
				{
					this.autoScroll = value;
				}
			}

        }
    }
}