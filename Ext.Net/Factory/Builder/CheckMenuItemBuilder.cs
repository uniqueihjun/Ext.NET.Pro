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
    public partial class CheckMenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TCheckMenuItem, TBuilder> : MenuItemBase.Builder<TCheckMenuItem, TBuilder>
            where TCheckMenuItem : CheckMenuItem
            where TBuilder : Builder<TCheckMenuItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TCheckMenuItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to prevent the checked item from being toggled. Any submenu will still be accessible. Defaults to: false
			/// </summary>
            public virtual TBuilder CheckChangeDisabled(bool checkChangeDisabled)
            {
                this.ToComponent().CheckChangeDisabled = checkChangeDisabled;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to initialize this checkbox as checked (defaults to false). Note that if this checkbox is part of a radio group (group = true) only the last item in the group that is initialized with checked = true will be rendered as checked.
			/// </summary>
            public virtual TBuilder Checked(bool _checked)
            {
                this.ToComponent().Checked = _checked;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class used by cls to show the checked state. Defaults to Ext.baseCSSPrefix + 'menu-item-checked'.
			/// </summary>
            public virtual TBuilder CheckedCls(string checkedCls)
            {
                this.ToComponent().CheckedCls = checkedCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// All check items with the same group name will automatically be grouped into a single-select radio button group (defaults to '').
			/// </summary>
            public virtual TBuilder Group(string group)
            {
                this.ToComponent().Group = group;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class applied to this item's icon image to denote being a part of a radio group. Defaults to Ext.baseCSSClass + 'menu-group-icon'. Any specified iconCls overrides this.
			/// </summary>
            public virtual TBuilder GroupCls(string groupCls)
            {
                this.ToComponent().GroupCls = groupCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The CSS class used by cls to show the unchecked state. Defaults to Ext.baseCSSPrefix + 'menu-item-unchecked'.
			/// </summary>
            public virtual TBuilder UncheckedCls(string uncheckedCls)
            {
                this.ToComponent().UncheckedCls = uncheckedCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A function that handles the checkchange event.
			/// </summary>
            public virtual TBuilder CheckHandler(string checkHandler)
            {
                this.ToComponent().CheckHandler = checkHandler;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<CheckMenuItemListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<CheckMenuItemDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetChecked(bool value, bool suppressEvent)
            {
                this.ToComponent().SetChecked(value, suppressEvent);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SetChecked(bool value)
            {
                this.ToComponent().SetChecked(value);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DisableCheckChange()
            {
                this.ToComponent().DisableCheckChange();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder EnableCheckChange()
            {
                this.ToComponent().EnableCheckChange();
                return this as TBuilder;
            }
            
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckMenuItem.Builder<CheckMenuItem, CheckMenuItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckMenuItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckMenuItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckMenuItem.Config config) : base(new CheckMenuItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckMenuItem component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckMenuItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckMenuItem(this);
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
        public CheckMenuItem.Builder CheckMenuItem()
        {
#if MVC
			return this.CheckMenuItem(new CheckMenuItem { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.CheckMenuItem(new CheckMenuItem());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckMenuItem.Builder CheckMenuItem(CheckMenuItem component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new CheckMenuItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckMenuItem.Builder CheckMenuItem(CheckMenuItem.Config config)
        {
#if MVC
			return new CheckMenuItem.Builder(new CheckMenuItem(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new CheckMenuItem.Builder(new CheckMenuItem(config));
#endif			
        }
    }
}