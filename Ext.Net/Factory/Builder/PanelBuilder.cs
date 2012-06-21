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
    public partial class Panel
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractPanel.Builder<Panel, Panel.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Panel()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Panel component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Panel.Config config) : base(new Panel(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Panel component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Panel.Builder</returns>
            public virtual Panel.Builder Listeners(Action<PanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as Panel.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of Panel.Builder</returns>
            public virtual Panel.Builder DirectEvents(Action<PanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as Panel.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Panel.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Panel(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Panel.Builder Panel()
        {
            return this.Panel(new Panel());
        }

        /// <summary>
        /// 
        /// </summary>
        public Panel.Builder Panel(Panel component)
        {
            return new Panel.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Panel.Builder Panel(Panel.Config config)
        {
            return new Panel.Builder(new Panel(config));
        }
    }
}