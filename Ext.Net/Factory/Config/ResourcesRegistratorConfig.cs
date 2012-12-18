/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class ResourcesRegistrator
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ResourcesRegistrator(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ResourcesRegistrator.Config Conversion to ResourcesRegistrator
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResourcesRegistrator(ResourcesRegistrator.Config config)
        {
            return new ResourcesRegistrator(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit ResourcesRegistrator.Config Conversion to ResourcesRegistrator.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ResourcesRegistrator.Builder(ResourcesRegistrator.Config config)
			{
				return new ResourcesRegistrator.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private List<ClientResourceItem> resourceItems = null;

			/// <summary>
			/// 
			/// </summary>
			public List<ClientResourceItem> ResourceItems
			{
				get
				{
					if (this.resourceItems == null)
					{
						this.resourceItems = new List<ClientResourceItem>();
					}
			
					return this.resourceItems;
				}
			}
			
        }
    }
}