/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class TreePanel
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public TreePanel(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit TreePanel.Config Conversion to TreePanel
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TreePanel(TreePanel.Config config)
        {
            return new TreePanel(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TreePanelBase.Config 
        { 
			/*  Implicit TreePanel.Config Conversion to TreePanel.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator TreePanel.Builder(TreePanel.Config config)
			{
				return new TreePanel.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string remoteEditUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteEditUrl 
			{ 
				get
				{
					return this.remoteEditUrl;
				}
				set
				{
					this.remoteEditUrl = value;
				}
			}

			private string remoteRemoveUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteRemoveUrl 
			{ 
				get
				{
					return this.remoteRemoveUrl;
				}
				set
				{
					this.remoteRemoveUrl = value;
				}
			}

			private string remoteAppendUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteAppendUrl 
			{ 
				get
				{
					return this.remoteAppendUrl;
				}
				set
				{
					this.remoteAppendUrl = value;
				}
			}

			private string remoteInsertUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteInsertUrl 
			{ 
				get
				{
					return this.remoteInsertUrl;
				}
				set
				{
					this.remoteInsertUrl = value;
				}
			}

			private string remoteMoveUrl = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string RemoteMoveUrl 
			{ 
				get
				{
					return this.remoteMoveUrl;
				}
				set
				{
					this.remoteMoveUrl = value;
				}
			}
        
			private TreePanelListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public TreePanelListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new TreePanelListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private TreePanelDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public TreePanelDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new TreePanelDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}