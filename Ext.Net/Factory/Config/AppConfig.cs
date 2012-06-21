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
    public partial class App
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public App(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit App.Config Conversion to App
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator App(App.Config config)
        {
            return new App(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ControllerBase.Config 
        { 
			/*  Implicit App.Config Conversion to App.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator App.Builder(App.Config config)
			{
				return new App.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ItemsCollection<Observable> launch = null;

			/// <summary>
			/// 
			/// </summary>
			public ItemsCollection<Observable> Launch
			{
				get
				{
					if (this.launch == null)
					{
						this.launch = new ItemsCollection<Observable>();
					}
			
					return this.launch;
				}
			}
			
			private string name = "";

			/// <summary>
			/// The name of your application. This will also be the namespace for your views, controllers models and stores. Don't use spaces or special characters in the name.
			/// </summary>
			[DefaultValue("")]
			public override string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

        }
    }
}