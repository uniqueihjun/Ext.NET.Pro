/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
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
        new public partial class Config : BaseItem.Config 
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

			private string handler = "";

			/// <summary>
			/// The function to call when KeyMap finds the expected key combination
			/// </summary>
			[DefaultValue("")]
			public virtual string Handler 
			{ 
				get
				{
					return this.handler;
				}
				set
				{
					this.handler = value;
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

			private EventAction defaultEventAction = EventAction.None;

			/// <summary>
			/// A default action to apply to the event. Possible values are: stopEvent, stopPropagation, preventDefault. If no value is set no action is performed.
			/// </summary>
			[DefaultValue(EventAction.None)]
			public virtual EventAction DefaultEventAction 
			{ 
				get
				{
					return this.defaultEventAction;
				}
				set
				{
					this.defaultEventAction = value;
				}
			}

			private string keysString = "";

			/// <summary>
			/// A single keycode or an array of keycodes to handle
			/// </summary>
			[DefaultValue("")]
			public virtual string KeysString 
			{ 
				get
				{
					return this.keysString;
				}
				set
				{
					this.keysString = value;
				}
			}

        }
    }
}