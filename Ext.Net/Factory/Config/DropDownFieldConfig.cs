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
    public partial class DropDownField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DropDownField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DropDownField.Config Conversion to DropDownField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DropDownField(DropDownField.Config config)
        {
            return new DropDownField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DropDownFieldBase.Config 
        { 
			/*  Implicit DropDownField.Config Conversion to DropDownField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DropDownField.Builder(DropDownField.Config config)
			{
				return new DropDownField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private PickerFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public PickerFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new PickerFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private PickerFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public PickerFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new PickerFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}