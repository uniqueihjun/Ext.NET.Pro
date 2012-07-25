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
    public partial class JsonPProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public JsonPProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit JsonPProxy.Config Conversion to JsonPProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonPProxy(JsonPProxy.Config config)
        {
            return new JsonPProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : ServerProxy.Config 
        { 
			/*  Implicit JsonPProxy.Config Conversion to JsonPProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator JsonPProxy.Builder(JsonPProxy.Config config)
			{
				return new JsonPProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool autoAppendParams = true;

			/// <summary>
			/// True to automatically append the request's params to the generated url. Defaults to true
			/// </summary>
			[DefaultValue(true)]
			public virtual bool AutoAppendParams 
			{ 
				get
				{
					return this.autoAppendParams;
				}
				set
				{
					this.autoAppendParams = value;
				}
			}

			private string callbackKey = "";

			/// <summary>
			/// Specifies the GET parameter that will be sent to the server containing the function name to be executed when the request completes. Defaults to callback. Thus, a common request will be in the form of url?callback=Ext.data.JsonP.callback1
			/// </summary>
			[DefaultValue("")]
			public virtual string CallbackKey 
			{ 
				get
				{
					return this.callbackKey;
				}
				set
				{
					this.callbackKey = value;
				}
			}

			private string recordParam = "";

			/// <summary>
			/// The param name to use when passing records to the server (e.g. 'records=someEncodedRecordString'). Defaults to 'records'
			/// </summary>
			[DefaultValue("")]
			public virtual string RecordParam 
			{ 
				get
				{
					return this.recordParam;
				}
				set
				{
					this.recordParam = value;
				}
			}

        }
    }
}