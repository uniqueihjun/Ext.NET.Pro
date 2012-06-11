/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class DropDownFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : PickerField.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string valueHiddenName = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ValueHiddenName 
			{ 
				get
				{
					return this.valueHiddenName;
				}
				set
				{
					this.valueHiddenName = value;
				}
			}

			private string underlyingValue = "";

			/// <summary>
			/// The underlying value which mapping on the Text, similar the Value property but can be set declarative
			/// </summary>
			[DefaultValue("")]
			public virtual string UnderlyingValue 
			{ 
				get
				{
					return this.underlyingValue;
				}
				set
				{
					this.underlyingValue = value;
				}
			}

			private DropDownMode mode = DropDownMode.Text;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(DropDownMode.Text)]
			public virtual DropDownMode Mode 
			{ 
				get
				{
					return this.mode;
				}
				set
				{
					this.mode = value;
				}
			}

			private bool allowBlur = false;

			/// <summary>
			/// False to hide the component when the field is blurred. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowBlur 
			{ 
				get
				{
					return this.allowBlur;
				}
				set
				{
					this.allowBlur = value;
				}
			}
        
			private ItemsCollection<AbstractPanel> component = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<AbstractPanel> Component
			{
				get
				{
					if (this.component == null)
					{
						this.component = new ItemsCollection<AbstractPanel>();
					}
			
					return this.component;
				}
			}
			
			private string componentRenderTo = "";

			/// <summary>
			/// The id of the node, a DOM node or an existing Element that will be the content Container to render this component into.
			/// </summary>
			[DefaultValue("")]
			public virtual string ComponentRenderTo 
			{ 
				get
				{
					return this.componentRenderTo;
				}
				set
				{
					this.componentRenderTo = value;
				}
			}
        
			private JFunction syncValue = null;

			/// <summary>
			/// Function to syncronize value of the field and dropdown control
			/// </summary>
			public JFunction SyncValue
			{
				get
				{
					if (this.syncValue == null)
					{
						this.syncValue = new JFunction();
					}
			
					return this.syncValue;
				}
			}
			
        }
    }
}