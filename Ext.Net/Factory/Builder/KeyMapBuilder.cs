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
    public partial class KeyMap
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : Observable.Builder<KeyMap, KeyMap.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new KeyMap()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(KeyMap component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(KeyMap.Config config) : base(new KeyMap(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(KeyMap component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// A KeyMap config object (in the format expected by Ext.KeyMap.addBinding used to assign custom key handling to this panel (defaults to null).
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of KeyMap.Builder</returns>
            public virtual KeyMap.Builder Keys(Action<KeyBindingCollection> action)
            {
                action(this.ToComponent().Keys);
                return this as KeyMap.Builder;
            }
			 
 			/// <summary>
			/// The element to bind to
			/// </summary>
            public virtual KeyMap.Builder Target(string target)
            {
                this.ToComponent().Target = target;
                return this as KeyMap.Builder;
            }
             
 			/// <summary>
			/// (optional) The event to bind to (defaults to 'keydown')
			/// </summary>
            public virtual KeyMap.Builder EventName(string eventName)
            {
                this.ToComponent().EventName = eventName;
                return this as KeyMap.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
 			/// <summary>
			/// 
			/// </summary>
            public virtual KeyMap.Builder Enable()
            {
                this.ToComponent().Enable();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual KeyMap.Builder Disable()
            {
                this.ToComponent().Disable();
                return this;
            }
            
 			/// <summary>
			/// 
			/// </summary>
            public virtual KeyMap.Builder AddKeyBinding(KeyBinding keyBinding)
            {
                this.ToComponent().AddKeyBinding(keyBinding);
                return this;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyMap.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.KeyMap(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public KeyMap.Builder KeyMap()
        {
            return this.KeyMap(new KeyMap());
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyMap.Builder KeyMap(KeyMap component)
        {
            return new KeyMap.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyMap.Builder KeyMap(KeyMap.Config config)
        {
            return new KeyMap.Builder(new KeyMap(config));
        }
    }
}