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
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DropDownField.Builder</returns>
            public virtual DropDownField.Builder Listeners(Action<PickerFieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as DropDownField.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DropDownField.Builder</returns>
            public virtual DropDownField.Builder DirectEvents(Action<PickerFieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as DropDownField.Builder;
            }
			

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