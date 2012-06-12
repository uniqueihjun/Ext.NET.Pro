/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public abstract partial class BaseMenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TBaseMenuItem, TBuilder> : Component.Builder<TBaseMenuItem, TBuilder>
            where TBaseMenuItem : BaseMenuItem
            where TBuilder : Builder<TBaseMenuItem, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TBaseMenuItem component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The CSS class to use when the item becomes activated (defaults to \"x-menu-item-active\").
			/// </summary>
            public virtual TBuilder ActiveClass(string activeClass)
            {
                this.ToComponent().ActiveClass = activeClass;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True if this item can be visually activated (defaults to false).
			/// </summary>
            public virtual TBuilder CanActivate(bool canActivate)
            {
                this.ToComponent().CanActivate = canActivate;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// A function that will handle the click event of this menu item (defaults to undefined).
			/// </summary>
            public virtual TBuilder Handler(string handler)
            {
                this.ToComponent().Handler = handler;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The scope (this reference) in which the handler function will be called.
			/// </summary>
            public virtual TBuilder Scope(string scope)
            {
                this.ToComponent().Scope = scope;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Length of time in milliseconds to wait before hiding after a click (defaults to 100).
			/// </summary>
            public virtual TBuilder HideDelay(int hideDelay)
            {
                this.ToComponent().HideDelay = hideDelay;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to hide the containing menu after this item is clicked (defaults to true).
			/// </summary>
            public virtual TBuilder HideOnClick(bool hideOnClick)
            {
                this.ToComponent().HideOnClick = hideOnClick;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}