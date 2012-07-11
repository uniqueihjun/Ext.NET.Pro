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
    public partial class DesktopModuleProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseControl.Builder<DesktopModuleProxy, DesktopModuleProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DesktopModuleProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopModuleProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopModuleProxy.Config config) : base(new DesktopModuleProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DesktopModuleProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModuleProxy.Builder Module(DesktopModule module)
            {
                this.ToComponent().Module = module;
                return this as DesktopModuleProxy.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DesktopModuleProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy.Builder DesktopModuleProxy()
        {
            return this.DesktopModuleProxy(new DesktopModuleProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy.Builder DesktopModuleProxy(DesktopModuleProxy component)
        {
            return new DesktopModuleProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy.Builder DesktopModuleProxy(DesktopModuleProxy.Config config)
        {
            return new DesktopModuleProxy.Builder(new DesktopModuleProxy(config));
        }
    }
}