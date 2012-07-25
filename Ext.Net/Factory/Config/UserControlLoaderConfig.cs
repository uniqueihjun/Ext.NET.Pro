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
    public partial class UserControlLoader
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit UserControlLoader.Config Conversion to UserControlLoader
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserControlLoader(UserControlLoader.Config config)
        {
            return new UserControlLoader(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractComponent.Config 
        { 
			/*  Implicit UserControlLoader.Config Conversion to UserControlLoader.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator UserControlLoader.Builder(UserControlLoader.Config config)
			{
				return new UserControlLoader.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string path = "";

			/// <summary>
			/// 
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

			private string userControlID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string UserControlID 
			{ 
				get
				{
					return this.userControlID;
				}
				set
				{
					this.userControlID = value;
				}
			}

			private ClientIDMode userControlClientIDMode = ClientIDMode.Inherit;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(ClientIDMode.Inherit)]
			public virtual ClientIDMode UserControlClientIDMode 
			{ 
				get
				{
					return this.userControlClientIDMode;
				}
				set
				{
					this.userControlClientIDMode = value;
				}
			}

        }
    }
}