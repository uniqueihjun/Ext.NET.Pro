/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class Observable
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract partial class Builder<TObservable, TBuilder> : BaseControl.Builder<TObservable, TBuilder>
            where TObservable : Observable
            where TBuilder : Builder<TObservable, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TObservable component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Collection of custom js config
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder CustomConfig(Action<ConfigItemCollection> action)
            {
                action(this.ToComponent().CustomConfig);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder MessageBusListeners(Action<MessageBusListeners> action)
            {
                action(this.ToComponent().MessageBusListeners);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder MessageBusDirectEvents(Action<MessageBusDirectEvents> action)
            {
                action(this.ToComponent().MessageBusDirectEvents);
                return this as TBuilder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddEvents(params string[] events)
            {
                this.ToComponent().AddEvents(events);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, JFunction fn)
            {
                this.ToComponent().AddListener(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, JFunction fn, string scope)
            {
                this.ToComponent().AddListener(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, JFunction fn, string scope, HandlerConfig options)
            {
                this.ToComponent().AddListener(eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, string fn)
            {
                this.ToComponent().AddListener(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, string fn, string scope)
            {
                this.ToComponent().AddListener(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddListener(string eventName, string fn, string scope, HandlerConfig options)
            {
                this.ToComponent().AddListener(eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddManagedListener(string item, string eventName, string fn, string scope, HandlerConfig options)
            {
                this.ToComponent().AddManagedListener(item, eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddManagedListener(string item, string eventName, string fn, string scope)
            {
                this.ToComponent().AddManagedListener(item, eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder AddManagedListener(string item, string eventName, string fn)
            {
                this.ToComponent().AddManagedListener(item, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ClearListeners()
            {
                this.ToComponent().ClearListeners();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ClearManagedListeners()
            {
                this.ToComponent().ClearManagedListeners();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder EnableBubble(params string[] events)
            {
                this.ToComponent().EnableBubble(events);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder FireEvent(string eventName, params object[] args)
            {
                this.ToComponent().FireEvent(eventName, args);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, string fn)
            {
                this.ToComponent().On(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, string fn, string scope)
            {
                this.ToComponent().On(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, string fn, string scope, HandlerConfig options)
            {
                this.ToComponent().On(eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, JFunction fn)
            {
                this.ToComponent().On(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, JFunction fn, string scope)
            {
                this.ToComponent().On(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder On(string eventName, JFunction fn, string scope, HandlerConfig options)
            {
                this.ToComponent().On(eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RelayEvents(string origin, string[] events)
            {
                this.ToComponent().RelayEvents(origin, events);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RemoveListener(string eventName, string fn)
            {
                this.ToComponent().RemoveListener(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RemoveListener(string eventName, string fn, string scope)
            {
                this.ToComponent().RemoveListener(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RemoveManagedListener(string item, string eventName, string fn)
            {
                this.ToComponent().RemoveManagedListener(item, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder RemoveManagedListener(string item, string eventName, string fn, string scope)
            {
                this.ToComponent().RemoveManagedListener(item, eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder ResumeEvents()
            {
                this.ToComponent().ResumeEvents();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Suspend the firing of all events. (see resumeEvents)
			/// </summary>
            public virtual TBuilder SuspendEvents(bool queueSuspended)
            {
                this.ToComponent().SuspendEvents(queueSuspended);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Suspend the firing of all events. (see resumeEvents)
			/// </summary>
            public virtual TBuilder SuspendEvents()
            {
                this.ToComponent().SuspendEvents();
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Removes a listener (shorthand for removeListener)
			/// </summary>
            public virtual TBuilder Un(string eventName, string fn)
            {
                this.ToComponent().Un(eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// Removes a listener (shorthand for removeListener)
			/// </summary>
            public virtual TBuilder Un(string eventName, string fn, string scope)
            {
                this.ToComponent().Un(eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Element el, string eventName, JFunction fn)
            {
                this.ToComponent().Mon(el, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Observable el, string eventName, JFunction fn)
            {
                this.ToComponent().Mon(el, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Element el, string eventName, JFunction fn, string scope)
            {
                this.ToComponent().Mon(el, eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Observable el, string eventName, JFunction fn, string scope)
            {
                this.ToComponent().Mon(el, eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Element el, string eventName, string fn, string scope, HandlerConfig options)
            {
                this.ToComponent().Mon(el, eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mon(Observable el, string eventName, string fn, string scope, HandlerConfig options)
            {
                this.ToComponent().Mon(el, eventName, fn, scope, options);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mun(Element el, string eventName, string fn)
            {
                this.ToComponent().Mun(el, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mun(Observable el, string eventName, string fn)
            {
                this.ToComponent().Mun(el, eventName, fn);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mun(Element el, string eventName, string fn, string scope)
            {
                this.ToComponent().Mun(el, eventName, fn, scope);
                return this as TBuilder;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual TBuilder Mun(Observable el, string eventName, string fn, string scope)
            {
                this.ToComponent().Mun(el, eventName, fn, scope);
                return this as TBuilder;
            }
            
        }        
    }
}