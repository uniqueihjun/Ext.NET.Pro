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
    public partial class Button
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ButtonBase.Builder<Button, Button.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Button()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Button component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Button.Config config) : base(new Button(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Button component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Button.Builder</returns>
            public virtual Button.Builder Listeners(Action<ButtonListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Button.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Button.Builder</returns>
            public virtual Button.Builder DirectEvents(Action<ButtonDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Button.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Button.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Button(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Button.Builder Button()
        {
            return this.Button(new Button());
        }

        /// <summary>
        /// 
        /// </summary>
        public Button.Builder Button(Button component)
        {
            return new Button.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Button.Builder Button(Button.Config config)
        {
            return new Button.Builder(new Button(config));
        }
    }
}