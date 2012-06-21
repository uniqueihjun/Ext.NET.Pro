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
    public partial class Tab
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<Tab, Tab.Builder>
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
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual Tab.Builder TabID(string tabID)
            {
                this.ToComponent().TabID = tabID;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// Managed container id. It will be shown when tab is activated
			/// </summary>
            public virtual Tab.Builder ActionItemID(string actionItemID)
            {
                this.ToComponent().ActionItemID = actionItemID;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// Managed container. It will be shown when tab is activated
			/// </summary>
            public virtual Tab.Builder ActionItem(AbstractComponent actionItem)
            {
                this.ToComponent().ActionItem = actionItem;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// How the action item. Supported values are 'visibility' (css visibility), 'offsets' (negative offset position) and 'display' (css display).
			/// </summary>
            public virtual Tab.Builder HideMode(HideMode hideMode)
            {
                this.ToComponent().HideMode = hideMode;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Tab.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// The tooltip for the button - can be a string to be used as innerHTML (html tags are accepted).
			/// </summary>
            public virtual Tab.Builder ToolTip(string toolTip)
            {
                this.ToComponent().ToolTip = toolTip;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// Panels themselves do not directly support being closed, but some Panel subclasses do (like Ext.Window) or a Panel Class within an Ext.TabPanel. Specify true to enable closing in such situations. Defaults to false.
			/// </summary>
            public virtual Tab.Builder Closable(bool closable)
            {
                this.ToComponent().Closable = closable;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// Render this component hidden (default is false). If true, the hide method will be called internally.
			/// </summary>
            public virtual Tab.Builder Hidden(bool hidden)
            {
                this.ToComponent().Hidden = hidden;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// True to disable the tab.
			/// </summary>
            public virtual Tab.Builder Disabled(bool disabled)
            {
                this.ToComponent().Disabled = disabled;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// The icon to use in the Button. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
            public virtual Tab.Builder Icon(Icon icon)
            {
                this.ToComponent().Icon = icon;
                return this as Tab.Builder;
            }
             
 			/// <summary>
			/// A css class which sets a background image to be used as the icon for this button.
			/// </summary>
            public virtual Tab.Builder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as Tab.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual Tab.Builder SetTooltip(string tooltip)
            {
                this.ToComponent().SetTooltip(tooltip);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Tab(this);
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
            return this.Tab(new Tab());
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder Tab(Tab component)
        {
            return new Tab.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Tab.Builder Tab(Tab.Config config)
        {
            return new Tab.Builder(new Tab(config));
        }
    }
}