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
    public partial class Slider
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : SliderBase.Builder<Slider, Slider.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Slider()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Slider component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Slider.Config config) : base(new Slider(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Slider component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Slider.Builder</returns>
            public virtual Slider.Builder Listeners(Action<SliderListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Slider.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Slider.Builder</returns>
            public virtual Slider.Builder DirectEvents(Action<SliderDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Slider.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Slider.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Slider(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Slider.Builder Slider()
        {
            return this.Slider(new Slider());
        }

        /// <summary>
        /// 
        /// </summary>
        public Slider.Builder Slider(Slider component)
        {
            return new Slider.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Slider.Builder Slider(Slider.Config config)
        {
            return new Slider.Builder(new Slider(config));
        }
    }
}