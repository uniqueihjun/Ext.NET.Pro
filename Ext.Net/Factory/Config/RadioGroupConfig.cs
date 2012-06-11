/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class RadioGroup
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public RadioGroup(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit RadioGroup.Config Conversion to RadioGroup
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RadioGroup(RadioGroup.Config config)
        {
            return new RadioGroup(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : CheckboxGroupBase.Config 
        { 
			/*  Implicit RadioGroup.Config Conversion to RadioGroup.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator RadioGroup.Builder(RadioGroup.Config config)
			{
				return new RadioGroup.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string defaultType = "Radio";

			/// <summary>
			/// The default type of content Container represented by this object as registered in Ext.ComponentMgr (defaults to 'radio').
			/// </summary>
			[DefaultValue("Radio")]
			public virtual string DefaultType 
			{ 
				get
				{
					return this.defaultType;
				}
				set
				{
					this.defaultType = value;
				}
			}
        
			private RadioGroupListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public RadioGroupListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new RadioGroupListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private RadioGroupDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public RadioGroupDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new RadioGroupDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			        
			private ItemsCollection<Radio> items = null;

			/// <summary>
			/// Items collection
			/// </summary>
			public ItemsCollection<Radio> Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ItemsCollection<Radio>();
					}
			
					return this.items;
				}
			}
			
			private bool automaticGrouping = true;

			/// <summary>
			/// Automatic grouping (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AutomaticGrouping 
			{ 
				get
				{
					return this.automaticGrouping;
				}
				set
				{
					this.automaticGrouping = value;
				}
			}

			private string groupName = "";

			/// <summary>
			/// The field's HTML name attribute.
			/// </summary>
			[DefaultValue("")]
			public virtual string GroupName 
			{ 
				get
				{
					return this.groupName;
				}
				set
				{
					this.groupName = value;
				}
			}

        }
    }
}