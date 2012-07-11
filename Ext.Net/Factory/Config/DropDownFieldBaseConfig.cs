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
    public abstract partial class DropDownFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : BaseTriggerField.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string text = "";

			/// <summary>
			/// The Text value to initialize this field with.
			/// </summary>
			[DefaultValue("")]
			public override string Text 
			{ 
				get
				{
					return this.text;
				}
				set
				{
					this.text = value;
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

			private bool lazyInit = true;

			/// <summary>
			/// True to not initialize the list for this combo until the field is focused. (defaults to true).
			/// </summary>
			[DefaultValue(true)]
			public virtual bool LazyInit 
			{ 
				get
				{
					return this.lazyInit;
				}
				set
				{
					this.lazyInit = value;
				}
			}

			private string componentAlign = "";

			/// <summary>
			/// A valid anchor position value. See Ext.Element.alignTo for details on supported anchor positions (defaults to 'tl-bl').
			/// </summary>
			[DefaultValue("")]
			public virtual string ComponentAlign 
			{ 
				get
				{
					return this.componentAlign;
				}
				set
				{
					this.componentAlign = value;
				}
			}
        
			private ItemsCollection<PanelBase> component = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<PanelBase> Component
			{
				get
				{
					if (this.component == null)
					{
						this.component = new ItemsCollection<PanelBase>();
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

        }
    }
}