/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DesktopModuleProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DesktopModuleProxy.Config Conversion to DesktopModuleProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DesktopModuleProxy(DesktopModuleProxy.Config config)
        {
            return new DesktopModuleProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseControl.Config 
        { 
			/*  Implicit DesktopModuleProxy.Config Conversion to DesktopModuleProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DesktopModuleProxy.Builder(DesktopModuleProxy.Config config)
			{
				return new DesktopModuleProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private DesktopModule module = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopModule Module 
			{ 
				get
				{
					return this.module;
				}
				set
				{
					this.module = value;
				}
			}

        }
    }
}