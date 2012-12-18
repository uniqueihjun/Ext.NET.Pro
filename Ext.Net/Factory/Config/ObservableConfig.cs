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
    public abstract partial class Observable
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseControl.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ConfigItemCollection customConfig = null;

			/// <summary>
			/// Collection of custom js config
			/// </summary>
			public ConfigItemCollection CustomConfig
			{
				get
				{
					if (this.customConfig == null)
					{
						this.customConfig = new ConfigItemCollection();
					}
			
					return this.customConfig;
				}
			}
			        
			private MessageBusListeners messageBusListeners = null;

			/// <summary>
			/// 
			/// </summary>
			public MessageBusListeners MessageBusListeners
			{
				get
				{
					if (this.messageBusListeners == null)
					{
						this.messageBusListeners = new MessageBusListeners();
					}
			
					return this.messageBusListeners;
				}
			}
			        
			private MessageBusDirectEvents messageBusDirectEvents = null;

			/// <summary>
			/// 
			/// </summary>
			public MessageBusDirectEvents MessageBusDirectEvents
			{
				get
				{
					if (this.messageBusDirectEvents == null)
					{
						this.messageBusDirectEvents = new MessageBusDirectEvents();
					}
			
					return this.messageBusDirectEvents;
				}
			}
			
        }
    }
}