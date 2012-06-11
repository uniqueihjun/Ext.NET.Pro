/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(RadioListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(RadioDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
            

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