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
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TreePanelBase.Builder<TreePanel, TreePanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TreePanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreePanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TreePanel.Config config) : base(new TreePanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TreePanel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TreePanel.Builder RemoteEditUrl(string remoteEditUrl)
            {
                this.ToComponent().RemoteEditUrl = remoteEditUrl;
                return this as TreePanel.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TreePanel.Builder RemoteRemoveUrl(string remoteRemoveUrl)
            {
                this.ToComponent().RemoteRemoveUrl = remoteRemoveUrl;
                return this as TreePanel.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TreePanel.Builder RemoteAppendUrl(string remoteAppendUrl)
            {
                this.ToComponent().RemoteAppendUrl = remoteAppendUrl;
                return this as TreePanel.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TreePanel.Builder RemoteInsertUrl(string remoteInsertUrl)
            {
                this.ToComponent().RemoteInsertUrl = remoteInsertUrl;
                return this as TreePanel.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TreePanel.Builder RemoteMoveUrl(string remoteMoveUrl)
            {
                this.ToComponent().RemoteMoveUrl = remoteMoveUrl;
                return this as TreePanel.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreePanel.Builder</returns>
            public virtual TreePanel.Builder Listeners(Action<TreePanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TreePanel.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TreePanel.Builder</returns>
            public virtual TreePanel.Builder DirectEvents(Action<TreePanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TreePanel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TreePanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel()
        {
            return this.TreePanel(new TreePanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel(TreePanel component)
        {
            return new TreePanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TreePanel.Builder TreePanel(TreePanel.Config config)
        {
            return new TreePanel.Builder(new TreePanel(config));
        }
    }
}