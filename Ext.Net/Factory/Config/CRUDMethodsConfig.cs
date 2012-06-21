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
    public partial class CRUDMethods
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CRUDMethods(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CRUDMethods.Config Conversion to CRUDMethods
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CRUDMethods(CRUDMethods.Config config)
        {
            return new CRUDMethods(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit CRUDMethods.Config Conversion to CRUDMethods.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CRUDMethods.Builder(CRUDMethods.Config config)
			{
				return new CRUDMethods.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private HttpMethod create = HttpMethod.Default;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(HttpMethod.Default)]
			public virtual HttpMethod Create 
			{ 
				get
				{
					return this.create;
				}
				set
				{
					this.create = value;
				}
			}

			private HttpMethod read = HttpMethod.Default;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(HttpMethod.Default)]
			public virtual HttpMethod Read 
			{ 
				get
				{
					return this.read;
				}
				set
				{
					this.read = value;
				}
			}

			private HttpMethod update = HttpMethod.Default;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(HttpMethod.Default)]
			public virtual HttpMethod Update 
			{ 
				get
				{
					return this.update;
				}
				set
				{
					this.update = value;
				}
			}

			private HttpMethod destroy = HttpMethod.Default;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(HttpMethod.Default)]
			public virtual HttpMethod Destroy 
			{ 
				get
				{
					return this.destroy;
				}
				set
				{
					this.destroy = value;
				}
			}

        }
    }
}