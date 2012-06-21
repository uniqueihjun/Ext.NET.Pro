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
    public partial class MultiSelect
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public MultiSelect(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit MultiSelect.Config Conversion to MultiSelect
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MultiSelect(MultiSelect.Config config)
        {
            return new MultiSelect(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MultiSelectBase.Config 
        { 
			/*  Implicit MultiSelect.Config Conversion to MultiSelect.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator MultiSelect.Builder(MultiSelect.Config config)
			{
				return new MultiSelect.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private MultiSelectListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public MultiSelectListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new MultiSelectListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private MultiSelectDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public MultiSelectDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new MultiSelectDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}