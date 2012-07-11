/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public abstract partial class EventDetailsBase
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TEventDetailsBase, TBuilder> : FormPanelBase.Builder<TEventDetailsBase, TBuilder>
            where TEventDetailsBase : EventDetailsBase
            where TBuilder : Builder<TEventDetailsBase, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TEventDetailsBase component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Title(string title)
            {
                this.ToComponent().Title = title;
                return this as TBuilder;
            }
             
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
			/// 
			/// </summary>
            public virtual TBuilder ButtonAlign(Alignment buttonAlign)
            {
                this.ToComponent().ButtonAlign = buttonAlign;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AutoHeight(bool autoHeight)
            {
                this.ToComponent().AutoHeight = autoHeight;
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
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }        
    }
}