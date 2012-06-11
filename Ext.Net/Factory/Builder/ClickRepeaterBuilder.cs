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
    public partial class ClickRepeater
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<ClickRepeater, ClickRepeater.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ClickRepeater()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ClickRepeater component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ClickRepeater.Config config) : base(new ClickRepeater(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ClickRepeater component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// True if autorepeating should start slowly and accelerate. Interval and Delay are ignored.
			/// </summary>
            public virtual ClickRepeater.Builder Accelerate(bool accelerate)
            {
                this.ToComponent().Accelerate = accelerate;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// The initial delay before the repeating event begins firing. Similar to an autorepeat key delay.
			/// </summary>
            public virtual ClickRepeater.Builder Delay(int delay)
            {
                this.ToComponent().Delay = delay;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// The element to act as a button.
			/// </summary>
            public virtual ClickRepeater.Builder Target(string target)
            {
                this.ToComponent().Target = target;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// The interval between firings of the \"click\" event. Default 20 ms.
			/// </summary>
            public virtual ClickRepeater.Builder Interval(int interval)
            {
                this.ToComponent().Interval = interval;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// A CSS class name to be applied to the element while pressed.
			/// </summary>
            public virtual ClickRepeater.Builder PressedCls(string pressedCls)
            {
                this.ToComponent().PressedCls = pressedCls;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// True to prevent the default click event.
			/// </summary>
            public virtual ClickRepeater.Builder PreventDefault(bool preventDefault)
            {
                this.ToComponent().PreventDefault = preventDefault;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// True to stop the default click event
			/// </summary>
            public virtual ClickRepeater.Builder StopDefault(bool stopDefault)
            {
                this.ToComponent().StopDefault = stopDefault;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// A function called when the traget is clicked (can be used instead of click event).
			/// </summary>
            public virtual ClickRepeater.Builder Handler(string handler)
            {
                this.ToComponent().Handler = handler;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// True to ignore the left button
			/// </summary>
            public virtual ClickRepeater.Builder IgnoreLeftButton(bool ignoreLeftButton)
            {
                this.ToComponent().IgnoreLeftButton = ignoreLeftButton;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// True to ignore the right button
			/// </summary>
            public virtual ClickRepeater.Builder IgnoreRightButton(bool ignoreRightButton)
            {
                this.ToComponent().IgnoreRightButton = ignoreRightButton;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// True to ignore the middle button
			/// </summary>
            public virtual ClickRepeater.Builder IgnoreMiddleButton(bool ignoreMiddleButton)
            {
                this.ToComponent().IgnoreMiddleButton = ignoreMiddleButton;
                return this as ClickRepeater.Builder;
            }
             
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ClickRepeater.Builder</returns>
            public virtual ClickRepeater.Builder Listeners(Action<ClickRepeaterListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as ClickRepeater.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ClickRepeater.Builder</returns>
            public virtual ClickRepeater.Builder DirectEvents(Action<ClickRepeaterDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as ClickRepeater.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ClickRepeater.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ClickRepeater(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ClickRepeater.Builder ClickRepeater()
        {
            return this.ClickRepeater(new ClickRepeater());
        }

        /// <summary>
        /// 
        /// </summary>
        public ClickRepeater.Builder ClickRepeater(ClickRepeater component)
        {
            return new ClickRepeater.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClickRepeater.Builder ClickRepeater(ClickRepeater.Config config)
        {
            return new ClickRepeater.Builder(new ClickRepeater(config));
        }
    }
}