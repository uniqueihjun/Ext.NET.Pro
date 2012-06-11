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
    public partial class DisplayField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DisplayField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DisplayField.Config Conversion to DisplayField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DisplayField(DisplayField.Config config)
        {
            return new DisplayField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Field.Config 
        { 
			/*  Implicit DisplayField.Config Conversion to DisplayField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DisplayField.Builder(DisplayField.Config config)
			{
				return new DisplayField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string fieldClass = "x-form-display-field";

			/// <summary>
			/// The default CSS class for the field (defaults to 'x-form-display-field')
			/// </summary>
			[DefaultValue("x-form-display-field")]
			public override string FieldClass 
			{ 
				get
				{
					return this.fieldClass;
				}
				set
				{
					this.fieldClass = value;
				}
			}

			private bool htmlEncode = false;

			/// <summary>
			/// false to skip HTML-encoding the text when rendering it (defaults to false). This might be useful if you want to include tags in the field's innerHTML rather than rendering them as string literals per the default logic.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HtmlEncode 
			{ 
				get
				{
					return this.htmlEncode;
				}
				set
				{
					this.htmlEncode = value;
				}
			}

			private string text = "";

			/// <summary>
			/// The plain text to display within the label (defaults to ''). If you need to include HTML tags within the label's innerHTML, use the html config instead.
			/// </summary>
			[DefaultValue("")]
			public virtual string Text 
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
        
			private FieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public FieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new FieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private FieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public FieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new FieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}