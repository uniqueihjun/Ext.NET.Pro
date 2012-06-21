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
    public partial class UserControlLoader
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : AbstractComponent.Builder<UserControlLoader, UserControlLoader.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new UserControlLoader()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UserControlLoader component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(UserControlLoader.Config config) : base(new UserControlLoader(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(UserControlLoader component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual UserControlLoader.Builder Path(string path)
            {
                this.ToComponent().Path = path;
                return this as UserControlLoader.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual UserControlLoader.Builder UserControlID(string userControlID)
            {
                this.ToComponent().UserControlID = userControlID;
                return this as UserControlLoader.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual UserControlLoader.Builder UserControlClientIDMode(ClientIDMode userControlClientIDMode)
            {
                this.ToComponent().UserControlClientIDMode = userControlClientIDMode;
                return this as UserControlLoader.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.UserControlLoader(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder UserControlLoader()
        {
            return this.UserControlLoader(new UserControlLoader());
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder UserControlLoader(UserControlLoader component)
        {
            return new UserControlLoader.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public UserControlLoader.Builder UserControlLoader(UserControlLoader.Config config)
        {
            return new UserControlLoader.Builder(new UserControlLoader(config));
        }
    }
}