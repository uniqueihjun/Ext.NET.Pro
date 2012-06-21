/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class DateField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : DateFieldBase.Builder<DateField, DateField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DateField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateField.Config config) : base(new DateField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DateField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DateField.Builder</returns>
            public virtual DateField.Builder Listeners(Action<DateFieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as DateField.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DateField.Builder</returns>
            public virtual DateField.Builder DirectEvents(Action<DateFieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as DateField.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DateField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DateField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DateField.Builder DateField()
        {
            return this.DateField(new DateField());
        }

        /// <summary>
        /// 
        /// </summary>
        public DateField.Builder DateField(DateField component)
        {
            return new DateField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateField.Builder DateField(DateField.Config config)
        {
            return new DateField.Builder(new DateField(config));
        }
    }
}