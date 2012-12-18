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
    public partial class JsonWriter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public JsonWriter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit JsonWriter.Config Conversion to JsonWriter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonWriter(JsonWriter.Config config)
        {
            return new JsonWriter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractWriter.Config 
        { 
			/*  Implicit JsonWriter.Config Conversion to JsonWriter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator JsonWriter.Builder(JsonWriter.Config config)
			{
				return new JsonWriter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string root = "";

			/// <summary>
			/// The HTTP parameter name by which JSON encoded records will be passed to the server if the encode option is `true`.
			/// </summary>
			[DefaultValue("")]
			public virtual string Root 
			{ 
				get
				{
					return this.root;
				}
				set
				{
					this.root = value;
				}
			}

			private bool encode = false;

			/// <summary>
			/// Configure `true` to send record data (all record fields if writeAllFields is `true`) as a JSON encoded HTTP parameter named by the root configuration.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Encode 
			{ 
				get
				{
					return this.encode;
				}
				set
				{
					this.encode = value;
				}
			}

			private bool allowSingle = false;

			/// <summary>
			/// False to ensure that records are always wrapped in an array, even if there is only one record being sent. When there is more than one record, they will always be encoded into an array.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowSingle 
			{ 
				get
				{
					return this.allowSingle;
				}
				set
				{
					this.allowSingle = value;
				}
			}

        }
    }
}