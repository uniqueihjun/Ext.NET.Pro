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
    public partial class CRUDUrls
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public CRUDUrls(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit CRUDUrls.Config Conversion to CRUDUrls
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CRUDUrls(CRUDUrls.Config config)
        {
            return new CRUDUrls(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit CRUDUrls.Config Conversion to CRUDUrls.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator CRUDUrls.Builder(CRUDUrls.Config config)
			{
				return new CRUDUrls.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string sync = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Sync 
			{ 
				get
				{
					return this.sync;
				}
				set
				{
					this.sync = value;
				}
			}

			private string create = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Create 
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

			private string read = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Read 
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

			private string update = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Update 
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

			private string destroy = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string Destroy 
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