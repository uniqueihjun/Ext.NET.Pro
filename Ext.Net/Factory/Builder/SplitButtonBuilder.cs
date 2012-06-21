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
    public partial class SplitButton
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : SplitButtonBase.Builder<SplitButton, SplitButton.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SplitButton()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitButton component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SplitButton.Config config) : base(new SplitButton(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SplitButton component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of SplitButton.Builder</returns>
            public virtual SplitButton.Builder Listeners(Action<SplitButtonListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as SplitButton.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of SplitButton.Builder</returns>
            public virtual SplitButton.Builder DirectEvents(Action<SplitButtonDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as SplitButton.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitButton.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SplitButton(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SplitButton.Builder SplitButton()
        {
            return this.SplitButton(new SplitButton());
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitButton.Builder SplitButton(SplitButton component)
        {
            return new SplitButton.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SplitButton.Builder SplitButton(SplitButton.Config config)
        {
            return new SplitButton.Builder(new SplitButton(config));
        }
    }
}