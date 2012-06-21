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
    public partial class TabPanel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractTabPanel.Builder<TabPanel, TabPanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TabPanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabPanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TabPanel.Config config) : base(new TabPanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TabPanel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TabPanel.Builder</returns>
            public virtual TabPanel.Builder Listeners(Action<TabPanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TabPanel.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TabPanel.Builder</returns>
            public virtual TabPanel.Builder DirectEvents(Action<TabPanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TabPanel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TabPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TabPanel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TabPanel.Builder TabPanel()
        {
            return this.TabPanel(new TabPanel());
        }

        /// <summary>
        /// 
        /// </summary>
        public TabPanel.Builder TabPanel(TabPanel component)
        {
            return new TabPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TabPanel.Builder TabPanel(TabPanel.Config config)
        {
            return new TabPanel.Builder(new TabPanel(config));
        }
    }
}