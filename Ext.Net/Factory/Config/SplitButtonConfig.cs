/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class SplitButton
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public SplitButton(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit SplitButton.Config Conversion to SplitButton
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SplitButton(SplitButton.Config config)
        {
            return new SplitButton(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : SplitButtonBase.Config 
        { 
			/*  Implicit SplitButton.Config Conversion to SplitButton.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator SplitButton.Builder(SplitButton.Config config)
			{
				return new SplitButton.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private SplitButtonListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public SplitButtonListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new SplitButtonListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private SplitButtonDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public SplitButtonDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new SplitButtonDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}