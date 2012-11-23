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
    public partial class Tab
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TTab, TBuilder> : BaseItem.Builder<TTab, TBuilder>
            where TTab : Tab
            where TBuilder : Builder<TTab, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TTab component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder TabID(string tabID)
            {
                this.ToComponent().TabID = tabID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Managed container id. It will be shown when tab is activated
			/// </summary>
            public virtual TBuilder ActionItemID(string actionItemID)
            {
                this.ToComponent().ActionItemID = actionItemID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Managed container. It will be shown when tab is activated
			/// </summary>
            public virtual TBuilder ActionItem(AbstractComponent actionItem)
            {
                this.ToComponent().ActionItem = actionItem;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// How the action item. Supported values are 'visibility' (css visibility), 'offsets' (negative offset position) and 'display' (css display).
			/// </summary>
            public virtual TBuilder HideMode(HideMode hideMode)
            {
                this.ToComponent().HideMode = hideMode;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The tooltip for the button - can be a string to be used as innerHTML (html tags are accepted).
			/// </summary>
            public virtual TBuilder ToolTip(string toolTip)
            {
                this.ToComponent().ToolTip = toolTip;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Panels themselves do not directly support being closed, but some Panel subclasses do (like Ext.Window) or a Panel Class within an Ext.TabPanel. Specify true to enable closing in such situations. Defaults to false.
			/// </summary>
            public virtual TBuilder Closable(bool closable)
            {
                this.ToComponent().Closable = closable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Render this component hidden (default is false). If true, the hide method will be called internally.
			/// </summary>
            public virtual TBuilder Hidden(bool hidden)
            {
                this.ToComponent().Hidden = hidden;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to disable the tab.
			/// </summary>
            public virtual TBuilder Disabled(bool disabled)
            {
                this.ToComponent().Disabled = disabled;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The icon to use in the Button. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
            public virtual TBuilder Icon(Icon icon)
            {
                this.ToComponent().Icon = icon;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A css class which sets a background image to be used as the icon for this button.
			/// </summary>
            public virtual TBuilder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetTooltip(string tooltip)
            {
                this.ToComponent().SetTooltip(tooltip);
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : Tab.Builder<Tab, Tab.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Tab()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Tab component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Tab.Config config) : base(new Tab(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Tab component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Tab(this);
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
        public Tab.Builder Tab()
        {
#if MVC
			return this.Tab(new Tab { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.Tab(new Tab());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder Tab(Tab component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new Tab.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder Tab(Tab.Config config)
        {
#if MVC
			return new Tab.Builder(new Tab(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new Tab.Builder(new Tab(config));
#endif			
        }
    }
}