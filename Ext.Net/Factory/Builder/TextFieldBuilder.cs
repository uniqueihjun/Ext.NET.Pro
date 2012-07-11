/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TextField
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : TextFieldBase.Builder<TextField, TextField.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new TextField()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TextField component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(TextField.Config config) : base(new TextField(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(TextField component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TextField.Builder</returns>
            public virtual TextField.Builder Listeners(Action<TextFieldListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as TextField.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TextField.Builder</returns>
            public virtual TextField.Builder DirectEvents(Action<TextFieldDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as TextField.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public TextField.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.TextField(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public TextField.Builder TextField()
        {
            return this.TextField(new TextField());
        }

        /// <summary>
        /// 
        /// </summary>
        public TextField.Builder TextField(TextField component)
        {
            return new TextField.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public TextField.Builder TextField(TextField.Config config)
        {
            return new TextField.Builder(new TextField(config));
        }
    }
}