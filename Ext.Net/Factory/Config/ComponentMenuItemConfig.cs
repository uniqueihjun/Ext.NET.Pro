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
    public partial class ComponentMenuItem
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ComponentMenuItem(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ComponentMenuItem.Config Conversion to ComponentMenuItem
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComponentMenuItem(ComponentMenuItem.Config config)
        {
            return new ComponentMenuItem(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : MenuItemBase.Config 
        { 
			/*  Implicit ComponentMenuItem.Config Conversion to ComponentMenuItem.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ComponentMenuItem.Builder(ComponentMenuItem.Config config)
			{
				return new ComponentMenuItem.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ItemsCollection<Component> component = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<Component> Component
			{
				get
				{
					if (this.component == null)
					{
						this.component = new ItemsCollection<Component>();
					}
			
					return this.component;
				}
			}
			
			private TargetElement componentElement = TargetElement.Auto;

			/// <summary>
			/// The element of component which will be used during menu item rendering
			/// </summary>
			[DefaultValue(TargetElement.Auto)]
			public virtual TargetElement ComponentElement 
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

			private bool shift = true;

			/// <summary>
			/// If true then element will be shiffted on horizontal, the icon place will be visible
			/// </summary>
			[DefaultValue(true)]
			public virtual bool Shift 
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

			private string target = "";

			/// <summary>
			/// The target element which will be placed to toolbar.
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

			private bool hideOnClick = false;

			/// <summary>
			/// True to hide the containing menu after this item is clicked (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public override bool HideOnClick 
			{ 
				get
				{
					return this.hideOnClick;
				}
				set
				{
					this.hideOnClick = value;
				}
			}

        }
    }
}