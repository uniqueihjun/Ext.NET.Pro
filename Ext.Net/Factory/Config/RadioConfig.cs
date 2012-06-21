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
    public partial class Radio
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Radio(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Radio.Config Conversion to Radio
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Radio(Radio.Config config)
        {
            return new Radio(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : CheckboxBase.Config 
        { 
			/*  Implicit Radio.Config Conversion to Radio.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Radio.Builder(Radio.Config config)
			{
				return new Radio.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private RadioListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public RadioListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new RadioListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private RadioDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public RadioDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new RadioDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}