/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class KeyBinding
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public KeyBinding(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit KeyBinding.Config Conversion to KeyBinding
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyBinding(KeyBinding.Config config)
        {
            return new KeyBinding(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit KeyBinding.Config Conversion to KeyBinding.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator KeyBinding.Builder(KeyBinding.Config config)
			{
				return new KeyBinding.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool? shift = null;

			/// <summary>
			/// True to handle key only when shift is pressed, False to handle the key only when shift is not pressed (defaults to undefined)
			/// </summary>
			[DefaultValue(null)]
			public virtual bool? Shift 
			{ 
				get
				{
					return this.shift;
				}
				set
				{
					this.shift = value;
				}
			}

			private bool? ctrl = null;

			/// <summary>
			/// True to handle key only when ctrl is pressed, False to handle the key only when ctrl is not pressed (defaults to undefined)
			/// </summary>
			[DefaultValue(null)]
			public virtual bool? Ctrl 
			{ 
				get
				{
					return this.ctrl;
				}
				set
				{
					this.ctrl = value;
				}
			}

			private bool? alt = null;

			/// <summary>
			/// True to handle key only when alt is pressed, False to handle the key only when alt is not pressed (defaults to undefined)
			/// </summary>
			[DefaultValue(null)]
			public virtual bool? Alt 
			{ 
				get
				{
					return this.alt;
				}
				set
				{
					this.alt = value;
				}
			}

			private bool stopEvent = false;

			/// <summary>
			/// True to stop the event from bubbling and prevent the default browser action if the key was handled by the KeyMap (defaults to false)
			/// </summary>
			[DefaultValue(false)]
			public virtual bool StopEvent 
			{ 
				get
				{
					return this.stopEvent;
				}
				set
				{
					this.stopEvent = value;
				}
			}

			private string scope = "";

			/// <summary>
			/// The scope of the callback function
			/// </summary>
			[DefaultValue("")]
			public virtual string Scope 
			{ 
				get
				{
					return this.scope;
				}
				set
				{
					this.scope = value;
				}
			}
        
			private KeyListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public KeyListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new KeyListeners();
					}
			
					return this.listeners;
				}
			}
			
        }
    }
}