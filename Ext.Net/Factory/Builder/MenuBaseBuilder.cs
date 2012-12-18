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
    public abstract partial class MenuBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TMenuBase, TBuilder> : AbstractPanel.Builder<TMenuBase, TBuilder>
            where TMenuBase : MenuBase
            where TBuilder : Builder<TMenuBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TMenuBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True to allow multiple menus to be displayed at the same time (defaults to false).
			/// </summary>
            public virtual TBuilder AllowOtherMenus(bool allowOtherMenus)
            {
                this.ToComponent().AllowOtherMenus = allowOtherMenus;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The default Ext.Element#getAlignToXY anchor position value for this menu relative to its element of origin. Defaults to: \"tl-bl?\"
			/// </summary>
            public virtual TBuilder DefaultAlign(string defaultAlign)
            {
                this.ToComponent().DefaultAlign = defaultAlign;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to ignore clicks on any item in this menu that is a parent item (displays a submenu) so that the submenu is not dismissed when clicking the parent item. Defaults to: false
			/// </summary>
            public virtual TBuilder IgnoreParentClicks(bool ignoreParentClicks)
            {
                this.ToComponent().IgnoreParentClicks = ignoreParentClicks;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to remove the incised line down the left side of the menu and to not indent general Component items. Defaults to: false
			/// </summary>
            public virtual TBuilder Plain(bool plain)
            {
                this.ToComponent().Plain = plain;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to show the icon separator. (defaults to true).
			/// </summary>
            public virtual TBuilder ShowSeparator(bool showSeparator)
            {
                this.ToComponent().ShowSeparator = showSeparator;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to enable keyboard navigation for controlling the menu. This option should generally be disabled when form fields are being used inside the menu. Defaults to true.
			/// </summary>
            public virtual TBuilder EnableKeyNav(bool enableKeyNav)
            {
                this.ToComponent().EnableKeyNav = enableKeyNav;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RenderToForm(bool renderToForm)
            {
                this.ToComponent().RenderToForm = renderToForm;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DeactivateActiveItem()
            {
                this.ToComponent().DeactivateActiveItem();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ShowBy(string element, string position, int[] offsets)
            {
                this.ToComponent().ShowBy(element, position, offsets);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ShowBy(string element, string position)
            {
                this.ToComponent().ShowBy(element, position);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ShowBy(string element)
            {
                this.ToComponent().ShowBy(element);
                return this as TBuilder;
            }
            
        }        
    }
}