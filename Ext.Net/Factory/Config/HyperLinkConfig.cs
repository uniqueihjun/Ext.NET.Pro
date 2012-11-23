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
    public partial class HyperLink
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public HyperLink(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit HyperLink.Config Conversion to HyperLink
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HyperLink(HyperLink.Config config)
        {
            return new HyperLink(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : LabelBase.Config 
        { 
			/*  Implicit HyperLink.Config Conversion to HyperLink.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator HyperLink.Builder(HyperLink.Config config)
			{
				return new HyperLink.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private AbstractComponentListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public AbstractComponentListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new AbstractComponentListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private AbstractComponentDirectEvents directEvents = null;

			/// <summary>
			/// Server-side Ajax Event Handlers
			/// </summary>
			public AbstractComponentDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new AbstractComponentDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
			private string imageUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ImageUrl 
			{ 
				get
				{
					return this.imageUrl;
				}
				set
				{
					this.imageUrl = value;
				}
			}

			private string navigateUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string NavigateUrl 
			{ 
				get
				{
					return this.navigateUrl;
				}
				set
				{
					this.navigateUrl = value;
				}
			}

			private string target = "";

			/// <summary>
			/// 
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

        }
    }
}