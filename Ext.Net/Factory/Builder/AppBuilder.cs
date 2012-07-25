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
    public partial class App
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ControllerBase.Builder<App, App.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new App()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(App component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(App.Config config) : base(new App(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(App component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of App.Builder</returns>
            public virtual App.Builder Launch(Action<ItemsCollection<Observable>> action)
            {
                action(this.ToComponent().Launch);
                return this as App.Builder;
            }
			 
 			/// <summary>
			/// The name of your application. This will also be the namespace for your views, controllers models and stores. Don't use spaces or special characters in the name.
			/// </summary>
            public virtual App.Builder Name(string name)
            {
                this.ToComponent().Name = name;
                return this as App.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.App(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public App.Builder App()
        {
            return this.App(new App());
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder App(App component)
        {
            return new App.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public App.Builder App(App.Config config)
        {
            return new App.Builder(new App(config));
        }
    }
}