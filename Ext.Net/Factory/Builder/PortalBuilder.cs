/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class Portal
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : PanelBase.Builder<Portal, Portal.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Portal()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portal component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Portal.Config config) : base(new Portal(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Portal component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(PortalListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side DirectEvent Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(PortalDirectEvents directEvents)
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
        public Portal.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Portal(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal()
        {
            return this.Portal(new Portal());
        }

        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal(Portal component)
        {
            return new Portal.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Portal.Builder Portal(Portal.Config config)
        {
            return new Portal.Builder(new Portal(config));
        }
    }
}