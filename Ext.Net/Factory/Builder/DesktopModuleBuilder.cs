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
    public partial class DesktopModule
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<DesktopModule, DesktopModule.Builder>
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
			/// Standard menu attribute consisting of a reference to a menu object, a menu id or a menu config blob.
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of DesktopModule.Builder</returns>
            public virtual DesktopModule.Builder Window(Action<WindowCollection> action)
            {
                action(this.ToComponent().Window);
                return this as DesktopModule.Builder;
            }
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder Launcher(MenuItem launcher)
            {
                this.ToComponent().Launcher = launcher;
                return this as DesktopModule.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder Shortcut(DesktopShortcut shortcut)
            {
                this.ToComponent().Shortcut = shortcut;
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
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual DesktopModule.Builder AutoRunHandler(string autoRunHandler)
            {
                this.ToComponent().AutoRunHandler = autoRunHandler;
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