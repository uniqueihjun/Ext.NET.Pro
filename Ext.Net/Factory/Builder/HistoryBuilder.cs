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
    public partial class History
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<History, History.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new History()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(History component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(History.Config config) : base(new History(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(History component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// False to don't render form tags. By default check ASP.NET form and if it is absent then render form.
			/// </summary>
            public virtual History.Builder RenderForm(bool renderForm)
            {
                this.ToComponent().RenderForm = renderForm;
                return this as History.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(HistoryListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEventHandlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(HistoryDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual History.Builder CallHistory(string name, params object[] args)
            {
                this.ToComponent().CallHistory(name, args);
                return this;
            }
            
 			/// <summary>
			/// Add a new token to the history stack. This can be any arbitrary value, although it would commonly be the concatenation of a component id and another id marking the specifc history state of that component.
			/// </summary>
            public virtual History.Builder Add(string token, bool preventDuplicate)
            {
                this.ToComponent().Add(token, preventDuplicate);
                return this;
            }
            
 			/// <summary>
			/// Add a new token to the history stack. This can be any arbitrary value, although it would commonly be the concatenation of a component id and another id marking the specifc history state of that component.
			/// </summary>
            public virtual History.Builder Add(string token)
            {
                this.ToComponent().Add(token);
                return this;
            }
            
 			/// <summary>
			/// Programmatically steps back one step in browser history (equivalent to the user pressing the Back button).
			/// </summary>
            public virtual History.Builder Back()
            {
                this.ToComponent().Back();
                return this;
            }
            
 			/// <summary>
			/// Programmatically steps forward one step in browser history (equivalent to the user pressing the Forward button).
			/// </summary>
            public virtual History.Builder Forward()
            {
                this.ToComponent().Forward();
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public History.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.History(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public History.Builder History()
        {
            return this.History(new History());
        }

        /// <summary>
        /// 
        /// </summary>
        public History.Builder History(History component)
        {
            return new History.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public History.Builder History(History.Config config)
        {
            return new History.Builder(new History(config));
        }
    }
}