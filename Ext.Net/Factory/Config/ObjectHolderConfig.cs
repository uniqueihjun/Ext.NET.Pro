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
    public partial class ObjectHolder
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ObjectHolder(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ObjectHolder.Config Conversion to ObjectHolder
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObjectHolder(ObjectHolder.Config config)
        {
            return new ObjectHolder(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit ObjectHolder.Config Conversion to ObjectHolder.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ObjectHolder.Builder(ObjectHolder.Config config)
			{
				return new ObjectHolder.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private JsonObject items = null;

			/// <summary>
			/// 
			/// </summary>
			public JsonObject Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new JsonObject();
					}
			
					return this.items;
				}
			}
			
        }
    }
}