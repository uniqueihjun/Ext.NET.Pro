/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class Checkbox
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : CheckboxBase.Builder<Checkbox, Checkbox.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Checkbox()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Checkbox component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Checkbox.Config config) : base(new Checkbox(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Checkbox component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(CheckboxListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(CheckboxDirectEvents directEvents)
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
        public Checkbox.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Checkbox(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Checkbox.Builder Checkbox()
        {
            return this.Checkbox(new Checkbox());
        }

        /// <summary>
        /// 
        /// </summary>
        public Checkbox.Builder Checkbox(Checkbox component)
        {
            return new Checkbox.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Checkbox.Builder Checkbox(Checkbox.Config config)
        {
            return new Checkbox.Builder(new Checkbox(config));
        }
    }
}