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
    public partial class NumberField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public NumberField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit NumberField.Config Conversion to NumberField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NumberField(NumberField.Config config)
        {
            return new NumberField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : NumberFieldBase.Config 
        { 
			/*  Implicit NumberField.Config Conversion to NumberField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator NumberField.Builder(NumberField.Config config)
			{
				return new NumberField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private NumberFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public NumberFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new NumberFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private NumberFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public NumberFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new NumberFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}