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
    public partial class FieldTrigger
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FieldTrigger(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FieldTrigger.Config Conversion to FieldTrigger
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FieldTrigger(FieldTrigger.Config config)
        {
            return new FieldTrigger(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit FieldTrigger.Config Conversion to FieldTrigger.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FieldTrigger.Builder(FieldTrigger.Config config)
			{
				return new FieldTrigger.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string tag = "";

			/// <summary>
			/// A trigger tag
			/// </summary>
			[DefaultValue("")]
			public virtual string Tag 
			{ 
				get
				{
					return this.tag;
				}
				set
				{
					this.tag = value;
				}
			}

			private bool hideTrigger = false;

			/// <summary>
			/// True to hide the trigger element and display only the base text field (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideTrigger 
			{ 
				get
				{
					return this.hideTrigger;
				}
				set
				{
					this.hideTrigger = value;
				}
			}

			private string triggerCls = "";

			/// <summary>
			/// A CSS class to apply to the trigger.
			/// </summary>
			[DefaultValue("")]
			public virtual string TriggerCls 
			{ 
				get
				{
					return this.triggerCls;
				}
				set
				{
					this.triggerCls = value;
				}
			}

			private TriggerIcon icon = TriggerIcon.Combo;

			/// <summary>
			/// The icon to use in the trigger. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
			[DefaultValue(TriggerIcon.Combo)]
			public virtual TriggerIcon Icon 
			{ 
				get
				{
					return this.icon;
				}
				set
				{
					this.icon = value;
				}
			}

			private string iconCls = "";

			/// <summary>
			/// A css class which sets a background image to be used as the icon for this button.
			/// </summary>
			[DefaultValue("")]
			public virtual string IconCls 
			{ 
				get
				{
					return this.iconCls;
				}
				set
				{
					this.iconCls = value;
				}
			}

			private string qtip = "";

			/// <summary>
			/// Quick tip.
			/// </summary>
			[DefaultValue("")]
			public virtual string Qtip 
			{ 
				get
				{
					return this.qtip;
				}
				set
				{
					this.qtip = value;
				}
			}

        }
    }
}