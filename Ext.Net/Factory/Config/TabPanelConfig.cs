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
    public partial class TabPanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TabPanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TabPanel.Config Conversion to TabPanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TabPanel(TabPanel.Config config)
        {
            return new TabPanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractTabPanel.Config 
        { 
			/*  Implicit TabPanel.Config Conversion to TabPanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TabPanel.Builder(TabPanel.Config config)
			{
				return new TabPanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private TabPanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public TabPanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new TabPanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private TabPanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public TabPanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new TabPanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}