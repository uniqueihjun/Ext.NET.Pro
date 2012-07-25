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
    public partial class SessionStorageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : WebStorageProxy.Builder<SessionStorageProxy, SessionStorageProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new SessionStorageProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SessionStorageProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(SessionStorageProxy.Config config) : base(new SessionStorageProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(SessionStorageProxy component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.SessionStorageProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy.Builder SessionStorageProxy()
        {
            return this.SessionStorageProxy(new SessionStorageProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy.Builder SessionStorageProxy(SessionStorageProxy component)
        {
            return new SessionStorageProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionStorageProxy.Builder SessionStorageProxy(SessionStorageProxy.Config config)
        {
            return new SessionStorageProxy.Builder(new SessionStorageProxy(config));
        }
    }
}