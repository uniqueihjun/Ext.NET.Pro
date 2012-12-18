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
    public partial class PanelHeader
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TPanelHeader, TBuilder> : AbstractContainer.Builder<TPanelHeader, TBuilder>
            where TPanelHeader : PanelHeader
            where TBuilder : Builder<TPanelHeader, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TPanelHeader component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The icon to use in the Title bar. See also, IconCls to set an icon with a custom Css class.
			/// </summary>
            public virtual TBuilder Icon(Icon icon)
            {
                this.ToComponent().Icon = icon;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A CSS class that will provide a background image to be used as the panel header icon (defaults to '').
			/// </summary>
            public virtual TBuilder IconCls(string iconCls)
            {
                this.ToComponent().IconCls = iconCls;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A CSS class that will provide a background image to be used as the panel header icon (defaults to '').
			/// </summary>
            public virtual TBuilder IconPath(string iconPath)
            {
                this.ToComponent().IconPath = iconPath;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Set a title for the panel's header. See Ext.panel.Header.title.
			/// </summary>
            public virtual TBuilder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// May be \"left\", \"right\" or \"center\". The alignment of the title text within the available space between the icon and the tools. Defaults to: \"left\"
			/// </summary>
            public virtual TBuilder TitleAlign(TitleAlign titleAlign)
            {
                this.ToComponent().TitleAlign = titleAlign;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder Listeners(Action<PanelHeaderListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DirectEvents(Action<PanelHeaderDirectEvents> action)
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
        public partial class Builder : PanelHeader.Builder<PanelHeader, PanelHeader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new PanelHeader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PanelHeader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(PanelHeader.Config config) : base(new PanelHeader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(PanelHeader component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public PanelHeader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.PanelHeader(this);
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
        public PanelHeader.Builder PanelHeader()
        {
#if MVC
			return this.PanelHeader(new PanelHeader { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.PanelHeader(new PanelHeader());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public PanelHeader.Builder PanelHeader(PanelHeader component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new PanelHeader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public PanelHeader.Builder PanelHeader(PanelHeader.Config config)
        {
#if MVC
			return new PanelHeader.Builder(new PanelHeader(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new PanelHeader.Builder(new PanelHeader(config));
#endif			
        }
    }
}