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
    public partial class Portal
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractPanel.Builder<Portal, Portal.Builder>
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
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Portal.Builder</returns>
            public virtual Portal.Builder Listeners(Action<PortalListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Portal.Builder;
            }
			 
 			/// <summary>
			/// Server-side DirectEvent Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Portal.Builder</returns>
            public virtual Portal.Builder DirectEvents(Action<PortalDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Portal.Builder;
            }
			 
 			/// <summary>
			/// true to use overflow:'auto' on the components layout element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).
			/// </summary>
            public virtual Portal.Builder AutoScroll(bool autoScroll)
            {
                this.ToComponent().AutoScroll = autoScroll;
                return this as Portal.Builder;
            }
            

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