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
    public partial class Radio
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckboxBase.Builder<Radio, Radio.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Radio()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Radio component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Radio.Config config) : base(new Radio(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Radio component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Radio.Builder</returns>
            public virtual Radio.Builder Listeners(Action<RadioListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Radio.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Radio.Builder</returns>
            public virtual Radio.Builder DirectEvents(Action<RadioDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Radio.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Radio.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Radio(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Radio.Builder Radio()
        {
            return this.Radio(new Radio());
        }

        /// <summary>
        /// 
        /// </summary>
        public Radio.Builder Radio(Radio component)
        {
            return new Radio.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Radio.Builder Radio(Radio.Config config)
        {
            return new Radio.Builder(new Radio(config));
        }
    }
}