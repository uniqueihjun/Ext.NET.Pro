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
    public partial class ChartTip
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ChartTip(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ChartTip.Config Conversion to ChartTip
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartTip(ChartTip.Config config)
        {
            return new ChartTip(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ToolTipBase.Config 
        { 
			/*  Implicit ChartTip.Config Conversion to ChartTip.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ChartTip.Builder(ChartTip.Config config)
			{
				return new ChartTip.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private JFunction renderer = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction Renderer
			{
				get
				{
					if (this.renderer == null)
					{
						this.renderer = new JFunction();
					}
			
					return this.renderer;
				}
			}
			
			private bool constrainPosition = false;

			/// <summary>
			/// If true, then the tooltip will be automatically constrained to stay within the browser viewport. Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public override bool ConstrainPosition 
			{ 
				get
				{
					return this.constrainPosition;
				}
				set
				{
					this.constrainPosition = value;
				}
			}
        
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