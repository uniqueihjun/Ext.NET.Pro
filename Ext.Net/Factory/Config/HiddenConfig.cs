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
    public partial class Hidden
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Hidden(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Hidden.Config Conversion to Hidden
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Hidden(Hidden.Config config)
        {
            return new Hidden(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Field.Config 
        { 
			/*  Implicit Hidden.Config Conversion to Hidden.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Hidden.Builder(Hidden.Config config)
			{
				return new Hidden.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string text = "";

			/// <summary>
			/// The Text value to initialize this field with.
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

			private object emptyValue = "";

			/// <summary>
			/// The fields null value.
			/// </summary>
			[DefaultValue("")]
			public override object EmptyValue 
			{ 
				get
				{
					return this.emptyValue;
				}
				set
				{
					this.emptyValue = value;
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