/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class Viewport
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ViewportBase.Builder<Viewport, Viewport.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Viewport()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Viewport component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Viewport.Config config) : base(new Viewport(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Viewport component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(ContainerListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(ContainerDirectEvents directEvents)
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
        public Viewport.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Viewport(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Viewport.Builder Viewport()
        {
            return this.Viewport(new Viewport());
        }

        /// <summary>
        /// 
        /// </summary>
        public Viewport.Builder Viewport(Viewport component)
        {
            return new Viewport.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Viewport.Builder Viewport(Viewport.Config config)
        {
            return new Viewport.Builder(new Viewport(config));
        }
    }
}