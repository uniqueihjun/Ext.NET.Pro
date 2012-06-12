/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class History
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public History(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit History.Config Conversion to History
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator History(History.Config config)
        {
            return new History(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit History.Config Conversion to History.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator History.Builder(History.Config config)
			{
				return new History.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool renderForm = true;

			/// <summary>
			/// False to don't render form tags. By default check ASP.NET form and if it is absent then render form.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RenderForm 
			{ 
				get
				{
					return this.renderForm;
				}
				set
				{
					this.renderForm = value;
				}
			}
        
			private HistoryListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public HistoryListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new HistoryListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private HistoryDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public HistoryDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new HistoryDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}