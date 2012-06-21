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
    public partial class Label
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : LabelBase.Builder<Label, Label.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Label()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Label component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Label.Config config) : base(new Label(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Label component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Label.Builder</returns>
            public virtual Label.Builder Listeners(Action<AbstractComponentListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Label.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Label.Builder</returns>
            public virtual Label.Builder DirectEvents(Action<AbstractComponentDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Label.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Label.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Label(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Label.Builder Label()
        {
            return this.Label(new Label());
        }

        /// <summary>
        /// 
        /// </summary>
        public Label.Builder Label(Label component)
        {
            return new Label.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Label.Builder Label(Label.Config config)
        {
            return new Label.Builder(new Label(config));
        }
    }
}