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
    public partial class FormPanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FormPanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FormPanel.Config Conversion to FormPanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FormPanel(FormPanel.Config config)
        {
            return new FormPanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : FormPanelBase.Config 
        { 
			/*  Implicit FormPanel.Config Conversion to FormPanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FormPanel.Builder(FormPanel.Config config)
			{
				return new FormPanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private FormPanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public FormPanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new FormPanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private FormPanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public FormPanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new FormPanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}