/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class DesktopModule
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : StateManagedItem.Builder<DesktopModule, DesktopModule.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DesktopModule()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopModule component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DesktopModule.Config config) : base(new DesktopModule(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DesktopModule component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder ModuleID(string moduleID)
            {
                this.ToComponent().ModuleID = moduleID;
                return this as DesktopModule.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder WindowID(string windowID)
            {
                this.ToComponent().WindowID = windowID;
                return this as DesktopModule.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder AutoRun(bool autoRun)
            {
                this.ToComponent().AutoRun = autoRun;
                return this as DesktopModule.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModule.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DesktopModule(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DesktopModule.Builder DesktopModule()
        {
            return this.DesktopModule(new DesktopModule());
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModule.Builder DesktopModule(DesktopModule component)
        {
            return new DesktopModule.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DesktopModule.Builder DesktopModule(DesktopModule.Config config)
        {
            return new DesktopModule.Builder(new DesktopModule(config));
        }
    }
}