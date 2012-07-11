/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class GenericPlugin
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public GenericPlugin(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit GenericPlugin.Config Conversion to GenericPlugin
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenericPlugin(GenericPlugin.Config config)
        {
            return new GenericPlugin(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Plugin.Config 
        { 
			/*  Implicit GenericPlugin.Config Conversion to GenericPlugin.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator GenericPlugin.Builder(GenericPlugin.Config config)
			{
				return new GenericPlugin.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string instanceName = "";

			/// <summary>
			/// The JavaScript class name. Used to create a 'new' instance of the object.
			/// </summary>
			[DefaultValue("")]
			public virtual string InstanceName 
			{ 
				get
				{
					return this.instanceName;
				}
				set
				{
					this.instanceName = value;
				}
			}

			private string path = "";

			/// <summary>
			/// The file path to the required JavaScript file.
			/// </summary>
			[DefaultValue("")]
			public virtual string Path 
			{ 
				get
				{
					return this.path;
				}
				set
				{
					this.path = value;
				}
			}

        }
    }
}