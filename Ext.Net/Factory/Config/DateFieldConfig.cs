/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class DateField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DateField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DateField.Config Conversion to DateField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DateField(DateField.Config config)
        {
            return new DateField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DateFieldBase.Config 
        { 
			/*  Implicit DateField.Config Conversion to DateField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DateField.Builder(DateField.Config config)
			{
				return new DateField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private DateFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DateFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DateFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DateFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public DateFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DateFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}