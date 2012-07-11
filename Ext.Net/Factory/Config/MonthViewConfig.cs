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
    public partial class MonthView
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MonthView(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MonthView.Config Conversion to MonthView
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MonthView(MonthView.Config config)
        {
            return new MonthView(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MonthViewBase.Config 
        { 
			/*  Implicit MonthView.Config Conversion to MonthView.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MonthView.Builder(MonthView.Config config)
			{
				return new MonthView.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private MonthViewListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public MonthViewListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new MonthViewListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private MonthViewDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public MonthViewDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new MonthViewDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}