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
    public partial class Slider
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Slider(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Slider.Config Conversion to Slider
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Slider(Slider.Config config)
        {
            return new Slider(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : SliderBase.Config 
        { 
			/*  Implicit Slider.Config Conversion to Slider.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Slider.Builder(Slider.Config config)
			{
				return new Slider.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private SliderListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public SliderListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new SliderListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private SliderDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public SliderDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new SliderDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}