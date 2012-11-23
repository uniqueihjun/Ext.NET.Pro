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
        new public partial class Config : LazyObservable.Config 
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
			        
			private KeyBindingCollection binding = null;

			/// <summary>
			/// Either a single object describing a handling function for s specified key (or set of keys), or an array of such objects.
			/// </summary>
			public KeyBindingCollection Binding
			{
				get
				{
					if (this.binding == null)
					{
						this.binding = new KeyBindingCollection();
					}
			
					return this.binding;
				}
			}
			
			private string eventName = "";

			/// <summary>
			/// The event to listen for to pick up key events. Defaults to: \"keydown\"
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

			private bool componentEvent = false;

			/// <summary>
			/// True to listen component event instead underlying element
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ComponentEvent 
			{ 
				get
				{
					return this.componentEvent;
				}
				set
				{
					this.componentEvent = value;
				}
			}

			private string componentElement = "";

			/// <summary>
			/// Element name of target component (can be used if KeyMap belongs to a component)
			/// </summary>
			[DefaultValue("")]
			public virtual string ComponentElement 
			{ 
				get
				{
					return this.componentElement;
				}
				set
				{
					this.componentElement = value;
				}
			}

			private bool ignoreInputFields = false;

			/// <summary>
			/// Configure this as true if there are any input fields within the target, and this KeyNav should not process events from input fields, (&lt;input>, &lt;textarea> and elements withcontentEditable=\"true\"). Defaults to: false
			/// </summary>
			[DefaultValue(false)]
			public virtual bool IgnoreInputFields 
			{ 
				get
				{
					return this.ignoreInputFields;
				}
				set
				{
					this.ignoreInputFields = value;
				}
			}
        
			private JFunction processEvent = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction ProcessEvent
			{
				get
				{
					if (this.processEvent == null)
					{
						this.processEvent = new JFunction();
					}
			
					return this.processEvent;
				}
			}
			
			private string processEventScope = "";

			/// <summary>
			/// The scope (this context) in which the processEvent method is executed.
			/// </summary>
			[DefaultValue("")]
			public virtual string ProcessEventScope 
			{ 
				get
				{
					return this.processEventScope;
				}
				set
				{
					this.processEventScope = value;
				}
			}

			private string target = "";

			/// <summary>
			/// The object on which to listen for the event specified by the eventName config option.
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

        }
    }
}