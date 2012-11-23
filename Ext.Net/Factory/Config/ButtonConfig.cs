/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class Button
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Button(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Button.Config Conversion to Button
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Button(Button.Config config)
        {
            return new Button(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ButtonBase.Config 
        { 
			/*  Implicit Button.Config Conversion to Button.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Button.Builder(Button.Config config)
			{
				return new Button.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ButtonListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ButtonListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ButtonListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ButtonDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public ButtonDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ButtonDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}