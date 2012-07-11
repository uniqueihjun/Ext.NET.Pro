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
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of History.Builder</returns>
            public virtual History.Builder Listeners(Action<HistoryListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as History.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of History.Builder</returns>
            public virtual History.Builder DirectEvents(Action<HistoryDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as History.Builder;
            }
			

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