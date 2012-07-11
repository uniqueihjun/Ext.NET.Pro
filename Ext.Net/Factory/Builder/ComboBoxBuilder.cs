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
    public partial class ComboBox
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ComboBoxBase.Builder<ComboBox, ComboBox.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ComboBox()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComboBox component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ComboBox.Config config) : base(new ComboBox(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ComboBox component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ComboBox.Builder</returns>
            public virtual ComboBox.Builder Listeners(Action<ComboBoxListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as ComboBox.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ComboBox.Builder</returns>
            public virtual ComboBox.Builder DirectEvents(Action<ComboBoxDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as ComboBox.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ComboBox(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox()
        {
            return this.ComboBox(new ComboBox());
        }

        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox(ComboBox component)
        {
            return new ComboBox.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComboBox.Builder ComboBox(ComboBox.Config config)
        {
            return new ComboBox.Builder(new ComboBox(config));
        }
    }
}