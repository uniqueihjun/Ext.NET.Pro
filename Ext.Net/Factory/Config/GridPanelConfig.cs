/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class GridPanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GridPanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GridPanel.Config Conversion to GridPanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GridPanel(GridPanel.Config config)
        {
            return new GridPanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : GridPanelBase.Config 
        { 
			/*  Implicit GridPanel.Config Conversion to GridPanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GridPanel.Builder(GridPanel.Config config)
			{
				return new GridPanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private GridPanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public GridPanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new GridPanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private GridPanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public GridPanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new GridPanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}