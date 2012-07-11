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
    public partial class ToolTip
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolTipBase.Builder<ToolTip, ToolTip.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolTip()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolTip component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolTip.Config config) : base(new ToolTip(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolTip component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// Client-side JavaScript Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ToolTip.Builder</returns>
            public virtual ToolTip.Builder Listeners(Action<PanelListeners> action)
            {
                action(this.ToComponent().Listeners);
                return this as ToolTip.Builder;
            }
			 
 			/// <summary>
			/// Server-side Ajax Event Handlers
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of ToolTip.Builder</returns>
            public virtual ToolTip.Builder DirectEvents(Action<PanelDirectEvents> action)
            {
                action(this.ToComponent().DirectEvents);
                return this as ToolTip.Builder;
            }
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolTip.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolTip(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolTip.Builder ToolTip()
        {
            return this.ToolTip(new ToolTip());
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolTip.Builder ToolTip(ToolTip component)
        {
            return new ToolTip.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolTip.Builder ToolTip(ToolTip.Config config)
        {
            return new ToolTip.Builder(new ToolTip(config));
        }
    }
}