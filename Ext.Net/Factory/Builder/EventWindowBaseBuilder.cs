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
    public abstract partial class EventWindowBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TEventWindowBase, TBuilder> : AbstractWindow.Builder<TEventWindowBase, TBuilder>
            where TEventWindowBase : EventWindowBase
            where TBuilder : Builder<TEventWindowBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TEventWindowBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The title during event adding
			/// </summary>
            public virtual TBuilder TitleTextAdd(string titleTextAdd)
            {
                this.ToComponent().TitleTextAdd = titleTextAdd;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The title during event editing
			/// </summary>
            public virtual TBuilder TitleTextEdit(string titleTextEdit)
            {
                this.ToComponent().TitleTextEdit = titleTextEdit;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The width of this component in pixels (defaults to auto).
			/// </summary>
            public virtual TBuilder Width(Unit width)
            {
                this.ToComponent().Width = width;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder DeletingMessage(string deletingMessage)
            {
                this.ToComponent().DeletingMessage = deletingMessage;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder SavingMessage(string savingMessage)
            {
                this.ToComponent().SavingMessage = savingMessage;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// True to allow user resizing at each edge and corner of the window, false to disable resizing (defaults to true).
			/// </summary>
            public virtual TBuilder Resizable(bool resizable)
            {
                this.ToComponent().Resizable = resizable;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ButtonAlign(Alignment buttonAlign)
            {
                this.ToComponent().ButtonAlign = buttonAlign;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The calendar store ID to use.
			/// </summary>
            public virtual TBuilder CalendarStoreID(string calendarStoreID)
            {
                this.ToComponent().CalendarStoreID = calendarStoreID;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The height of this component in pixels (defaults to auto).
			/// </summary>
            public virtual TBuilder Height(Unit height)
            {
                this.ToComponent().Height = height;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}