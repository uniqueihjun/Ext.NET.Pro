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
    public partial class DrawComponent
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractDrawComponent.Builder<DrawComponent, DrawComponent.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DrawComponent()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawComponent component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DrawComponent.Config config) : base(new DrawComponent(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DrawComponent component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DrawComponent.Builder</returns>
            public virtual DrawComponent.Builder Listeners(Action<DrawComponentListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as DrawComponent.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEventHandlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DrawComponent.Builder</returns>
            public virtual DrawComponent.Builder DirectEvents(Action<DrawComponentDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as DrawComponent.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawComponent.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DrawComponent(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DrawComponent.Builder DrawComponent()
        {
            return this.DrawComponent(new DrawComponent());
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawComponent.Builder DrawComponent(DrawComponent component)
        {
            return new DrawComponent.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DrawComponent.Builder DrawComponent(DrawComponent.Config config)
        {
            return new DrawComponent.Builder(new DrawComponent(config));
        }
    }
}