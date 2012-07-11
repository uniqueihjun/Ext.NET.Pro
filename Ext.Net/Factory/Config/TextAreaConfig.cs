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
    public partial class TextArea
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TextArea(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TextArea.Config Conversion to TextArea
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextArea(TextArea.Config config)
        {
            return new TextArea(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TextFieldBase.Config 
        { 
			/*  Implicit TextArea.Config Conversion to TextArea.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TextArea.Builder(TextArea.Config config)
			{
				return new TextArea.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private Unit growMax = Unit.Pixel(1000);

			/// <summary>
			/// The maximum width to allow when grow = true (defaults to 800).
			/// </summary>
			[DefaultValue(typeof(Unit), "1000")]
			public override Unit GrowMax 
			{ 
				get
				{
					return this.growMax;
				}
				set
				{
					this.growMax = value;
				}
			}

			private Unit growMin = Unit.Pixel(60);

			/// <summary>
			/// The minimum width to allow when grow = true (defaults to 60).
			/// </summary>
			[DefaultValue(typeof(Unit), "60")]
			public override Unit GrowMin 
			{ 
				get
				{
					return this.growMin;
				}
				set
				{
					this.growMin = value;
				}
			}

			private bool preventScrollbars = false;

			/// <summary>
			/// True to prevent scrollbars from appearing regardless of how much text is in the field (equivalent to setting overflow: hidden, defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool PreventScrollbars 
			{ 
				get
				{
					return this.preventScrollbars;
				}
				set
				{
					this.preventScrollbars = value;
				}
			}
        
			private TextFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public TextFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new TextFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private TextFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public TextFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new TextFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}