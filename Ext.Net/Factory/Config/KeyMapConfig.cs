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
    public partial class KeyMap
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public KeyMap(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit KeyMap.Config Conversion to KeyMap
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyMap(KeyMap.Config config)
        {
            return new KeyMap(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit KeyMap.Config Conversion to KeyMap.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator KeyMap.Builder(KeyMap.Config config)
			{
				return new KeyMap.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private KeyBindingCollection keys = null;

			/// <summary>
			/// A KeyMap config object (in the format expected by Ext.KeyMap.addBinding used to assign custom key handling to this panel (defaults to null).
			/// </summary>
			public KeyBindingCollection Keys
			{
				get
				{
					if (this.keys == null)
					{
						this.keys = new KeyBindingCollection();
					}
			
					return this.keys;
				}
			}
			
			private string target = "";

			/// <summary>
			/// The element to bind to
			/// </summary>
			[DefaultValue("")]
			public virtual string Target 
			{ 
				get
				{
					return this.target;
				}
				set
				{
					this.target = value;
				}
			}

			private string eventName = "";

			/// <summary>
			/// (optional) The event to bind to (defaults to 'keydown')
			/// </summary>
			[DefaultValue("")]
			public virtual string EventName 
			{ 
				get
				{
					return this.eventName;
				}
				set
				{
					this.eventName = value;
				}
			}

        }
    }
}