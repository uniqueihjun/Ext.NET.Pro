/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class KeyNav
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<KeyNav, KeyNav.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new KeyNav()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(KeyNav component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(KeyNav.Config config) : base(new KeyNav(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(KeyNav component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The element to bind to
			/// </summary>
            public virtual KeyNav.Builder Target(string target)
            {
                this.ToComponent().Target = target;
                return this as KeyNav.Builder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Left(Action<JFunction> action)
            {
                action(this.ToComponent().Left);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Right(Action<JFunction> action)
            {
                action(this.ToComponent().Right);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Up(Action<JFunction> action)
            {
                action(this.ToComponent().Up);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Down(Action<JFunction> action)
            {
                action(this.ToComponent().Down);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder PageUp(Action<JFunction> action)
            {
                action(this.ToComponent().PageUp);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder PageDown(Action<JFunction> action)
            {
                action(this.ToComponent().PageDown);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Del(Action<JFunction> action)
            {
                action(this.ToComponent().Del);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Home(Action<JFunction> action)
            {
                action(this.ToComponent().Home);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder End(Action<JFunction> action)
            {
                action(this.ToComponent().End);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Enter(Action<JFunction> action)
            {
                action(this.ToComponent().Enter);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Esc(Action<JFunction> action)
            {
                action(this.ToComponent().Esc);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyNav.Builder</returns>
            public virtual KeyNav.Builder Tab(Action<JFunction> action)
            {
                action(this.ToComponent().Tab);
                return this as KeyNav.Builder;
            }
			 
 			/// <summary>
			/// The method to call on the Ext.EventObject after this KeyNav intercepts a key. Valid values are Ext.EventObject.stopEvent, Ext.EventObject.preventDefault and Ext.EventObject.stopPropagation (defaults to 'stopEvent')
			/// </summary>
            public virtual KeyNav.Builder DefaultEventAction(KeyEventAction defaultEventAction)
            {
                this.ToComponent().DefaultEventAction = defaultEventAction;
                return this as KeyNav.Builder;
            }
             
 			/// <summary>
			/// True to disable this KeyNav instance (defaults to false)
			/// </summary>
            public virtual KeyNav.Builder Disabled(bool disabled)
            {
                this.ToComponent().Disabled = disabled;
                return this as KeyNav.Builder;
            }
             
 			/// <summary>
			/// Handle the keydown event instead of keypress (defaults to false). KeyNav automatically does this for IE since IE does not propagate special keys on keypress, but setting this to true will force other browsers to also handle keydown instead of keypress.
			/// </summary>
            public virtual KeyNav.Builder ForceKeyDown(bool forceKeyDown)
            {
                this.ToComponent().ForceKeyDown = forceKeyDown;
                return this as KeyNav.Builder;
            }
             
 			/// <summary>
			/// The scope of the callback function
			/// </summary>
            public virtual KeyNav.Builder Scope(string scope)
            {
                this.ToComponent().Scope = scope;
                return this as KeyNav.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyNav.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.KeyNav(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public KeyNav.Builder KeyNav()
        {
            return this.KeyNav(new KeyNav());
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyNav.Builder KeyNav(KeyNav component)
        {
            return new KeyNav.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyNav.Builder KeyNav(KeyNav.Config config)
        {
            return new KeyNav.Builder(new KeyNav(config));
        }
    }
}