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
    public partial class FileUploadField
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public FileUploadField(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit FileUploadField.Config Conversion to FileUploadField
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileUploadField(FileUploadField.Config config)
        {
            return new FileUploadField(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TextFieldBase.Config 
        { 
			/*  Implicit FileUploadField.Config Conversion to FileUploadField.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator FileUploadField.Builder(FileUploadField.Config config)
			{
				return new FileUploadField.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private Button button = null;

			/// <summary>
			/// A standard Ext.button.Button config object.
			/// </summary>
			public Button Button
			{
				get
				{
					if (this.button == null)
					{
						this.button = new Button();
					}
			
					return this.button;
				}
			}
			
			private string buttonText = "Browse...";

			/// <summary>
			/// The button text to display on the upload button (defaults to 'Browse...'). Note that if you supply a value for buttonConfig, the buttonConfig.text value will be used instead if available.
			/// </summary>
			[DefaultValue("Browse...")]
			public virtual string ButtonText 
			{ 
				get
				{
					return this.buttonText;
				}
				set
				{
					this.buttonText = value;
				}
			}

			private bool buttonOnly = false;

			/// <summary>
			/// True to display the file upload field as a button with no visible text field (defaults to false). If true, all inherited Text members will still be available.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool ButtonOnly 
			{ 
				get
				{
					return this.buttonOnly;
				}
				set
				{
					this.buttonOnly = value;
				}
			}

			private int buttonMargin = 3;

			/// <summary>
			/// The number of pixels of space reserved between the button and the text field (defaults to 3). Note that this only applies if buttonOnly = false.
			/// </summary>
			[DefaultValue(3)]
			public virtual int ButtonMargin 
			{ 
				get
				{
					return this.buttonMargin;
				}
				set
				{
					this.buttonMargin = value;
				}
			}
        
			private FileUploadFieldListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public FileUploadFieldListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new FileUploadFieldListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private FileUploadFieldDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public FileUploadFieldDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new FileUploadFieldDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}