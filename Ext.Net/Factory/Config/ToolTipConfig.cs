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
    public partial class ToolTip
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ToolTip(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ToolTip.Config Conversion to ToolTip
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolTip(ToolTip.Config config)
        {
            return new ToolTip(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolTipBase.Config 
        { 
			/*  Implicit ToolTip.Config Conversion to ToolTip.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ToolTip.Builder(ToolTip.Config config)
			{
				return new ToolTip.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private PanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public PanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new PanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private PanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public PanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new PanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}