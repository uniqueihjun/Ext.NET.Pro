/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class Image
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Image(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Image.Config Conversion to Image
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Image(Image.Config config)
        {
            return new Image(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ImageBase.Config 
        { 
			/*  Implicit Image.Config Conversion to Image.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Image.Builder(Image.Config config)
			{
				return new Image.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ImageListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public ImageListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new ImageListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private ImageDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public ImageDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new ImageDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}