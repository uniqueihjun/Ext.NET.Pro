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
    public partial class DropDownField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DropDownFieldBase.Builder<DropDownField, DropDownField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DropDownField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DropDownField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DropDownField.Config config) : base(new DropDownField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DropDownField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(DropDownFieldListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(DropDownFieldDirectEvents directEvents)
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
        public DropDownField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DropDownField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DropDownField.Builder DropDownField()
        {
            return this.DropDownField(new DropDownField());
        }

        /// <summary>
        /// 
        /// </summary>
        public DropDownField.Builder DropDownField(DropDownField component)
        {
            return new DropDownField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DropDownField.Builder DropDownField(DropDownField.Config config)
        {
            return new DropDownField.Builder(new DropDownField(config));
        }
    }
}