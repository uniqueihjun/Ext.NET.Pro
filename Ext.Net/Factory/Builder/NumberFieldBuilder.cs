/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class NumberField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : NumberFieldBase.Builder<NumberField, NumberField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new NumberField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumberField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(NumberField.Config config) : base(new NumberField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(NumberField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(NumberFieldListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(NumberFieldDirectEvents directEvents)
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
        public NumberField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.NumberField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public NumberField.Builder NumberField()
        {
            return this.NumberField(new NumberField());
        }

        /// <summary>
        /// 
        /// </summary>
        public NumberField.Builder NumberField(NumberField component)
        {
            return new NumberField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public NumberField.Builder NumberField(NumberField.Config config)
        {
            return new NumberField.Builder(new NumberField(config));
        }
    }
}