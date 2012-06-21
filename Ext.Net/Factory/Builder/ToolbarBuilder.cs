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
    public partial class Toolbar
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarBase.Builder<Toolbar, Toolbar.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Toolbar()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Toolbar component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Toolbar.Config config) : base(new Toolbar(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Toolbar component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Toolbar.Builder</returns>
            public virtual Toolbar.Builder Listeners(Action<ToolbarListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Toolbar.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Toolbar.Builder</returns>
            public virtual Toolbar.Builder DirectEvents(Action<ToolbarDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Toolbar.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Toolbar.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Toolbar(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Toolbar.Builder Toolbar()
        {
            return this.Toolbar(new Toolbar());
        }

        /// <summary>
        /// 
        /// </summary>
        public Toolbar.Builder Toolbar(Toolbar component)
        {
            return new Toolbar.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Toolbar.Builder Toolbar(Toolbar.Config config)
        {
            return new Toolbar.Builder(new Toolbar(config));
        }
    }
}