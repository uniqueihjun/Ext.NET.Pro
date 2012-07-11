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
    public partial class LocalStorageProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : WebStorageProxy.Builder<LocalStorageProxy, LocalStorageProxy.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new LocalStorageProxy()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LocalStorageProxy component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(LocalStorageProxy.Config config) : base(new LocalStorageProxy(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(LocalStorageProxy component)
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
        public LocalStorageProxy.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.LocalStorageProxy(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public LocalStorageProxy.Builder LocalStorageProxy()
        {
            return this.LocalStorageProxy(new LocalStorageProxy());
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalStorageProxy.Builder LocalStorageProxy(LocalStorageProxy component)
        {
            return new LocalStorageProxy.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalStorageProxy.Builder LocalStorageProxy(LocalStorageProxy.Config config)
        {
            return new LocalStorageProxy.Builder(new LocalStorageProxy(config));
        }
    }
}