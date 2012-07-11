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
    public partial class GridView
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GridView(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GridView.Config Conversion to GridView
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GridView(GridView.Config config)
        {
            return new GridView(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TableView.Config 
        { 
			/*  Implicit GridView.Config Conversion to GridView.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GridView.Builder(GridView.Config config)
			{
				return new GridView.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool stripeRows = true;

			/// <summary>
			/// True to stripe the rows. Default is true.
			/// </summary>
			[DefaultValue(true)]
			public virtual bool StripeRows 
			{ 
				get
				{
					return this.stripeRows;
				}
				set
				{
					this.stripeRows = value;
				}
			}
        
			private GridViewListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public GridViewListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new GridViewListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private GridViewDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public GridViewDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new GridViewDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}