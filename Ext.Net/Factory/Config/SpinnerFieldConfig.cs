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
    public partial class SpinnerField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SpinnerField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SpinnerField.Config Conversion to SpinnerField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SpinnerField(SpinnerField.Config config)
        {
            return new SpinnerField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : SpinnerFieldBase.Config 
        { 
			/*  Implicit SpinnerField.Config Conversion to SpinnerField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SpinnerField.Builder(SpinnerField.Config config)
			{
				return new SpinnerField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private SpinnerFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public SpinnerFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new SpinnerFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private SpinnerFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public SpinnerFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new SpinnerFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}