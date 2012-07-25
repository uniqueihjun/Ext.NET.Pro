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
    public partial class CheckboxGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckboxGroupBase.Builder<CheckboxGroup, CheckboxGroup.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new CheckboxGroup()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(CheckboxGroup.Config config) : base(new CheckboxGroup(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(CheckboxGroup component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CheckboxGroup.Builder</returns>
            public virtual CheckboxGroup.Builder Listeners(Action<CheckboxGroupListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as CheckboxGroup.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of CheckboxGroup.Builder</returns>
            public virtual CheckboxGroup.Builder DirectEvents(Action<CheckboxGroupDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as CheckboxGroup.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.CheckboxGroup(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup()
        {
            return this.CheckboxGroup(new CheckboxGroup());
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup component)
        {
            return new CheckboxGroup.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public CheckboxGroup.Builder CheckboxGroup(CheckboxGroup.Config config)
        {
            return new CheckboxGroup.Builder(new CheckboxGroup(config));
        }
    }
}