/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class GroupTabPanel
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TGroupTabPanel, TBuilder> : AbstractContainer.Builder<TGroupTabPanel, TBuilder>
            where TGroupTabPanel : GroupTabPanel
            where TBuilder : Builder<TGroupTabPanel, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TGroupTabPanel component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Deferred Render
			/// </summary>
            public virtual TBuilder DeferredRender(bool deferredRender)
            {
                this.ToComponent().DeferredRender = deferredRender;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Active group
			/// </summary>
            public virtual TBuilder ActiveGroup(string activeGroup)
            {
                this.ToComponent().ActiveGroup = activeGroup;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ActiveGroupIndex(int activeGroupIndex)
            {
                this.ToComponent().ActiveGroupIndex = activeGroupIndex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Active tab
			/// </summary>
            public virtual TBuilder ActiveTab(string activeTab)
            {
                this.ToComponent().ActiveTab = activeTab;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ActiveTabIndex(int activeTabIndex)
            {
                this.ToComponent().ActiveTabIndex = activeTabIndex;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The initial width in pixels of each new tab (defaults to 120).
			/// </summary>
            public virtual TBuilder TabWidth(Unit tabWidth)
            {
                this.ToComponent().TabWidth = tabWidth;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<GroupTabPanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<GroupTabPanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : GroupTabPanel.Builder<GroupTabPanel, GroupTabPanel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new GroupTabPanel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupTabPanel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(GroupTabPanel.Config config) : base(new GroupTabPanel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(GroupTabPanel component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupTabPanel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.GroupTabPanel(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public GroupTabPanel.Builder GroupTabPanel()
        {
#if MVC
			return this.GroupTabPanel(new GroupTabPanel { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.GroupTabPanel(new GroupTabPanel());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupTabPanel.Builder GroupTabPanel(GroupTabPanel component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new GroupTabPanel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public GroupTabPanel.Builder GroupTabPanel(GroupTabPanel.Config config)
        {
#if MVC
			return new GroupTabPanel.Builder(new GroupTabPanel(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new GroupTabPanel.Builder(new GroupTabPanel(config));
#endif			
        }
    }
}