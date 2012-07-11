/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class ScriptTagProxy
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ScriptTagProxy(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ScriptTagProxy.Config Conversion to ScriptTagProxy
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScriptTagProxy(ScriptTagProxy.Config config)
        {
            return new ScriptTagProxy(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : DataProxy.Config 
        { 
			/*  Implicit ScriptTagProxy.Config Conversion to ScriptTagProxy.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ScriptTagProxy.Builder(ScriptTagProxy.Config config)
			{
				return new ScriptTagProxy.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string callbackParam = "callback";

			/// <summary>
			/// The name of the parameter to pass to the server which tells the server the name of the callback function set up by the load call to process the returned data object.
			/// </summary>
			[DefaultValue("callback")]
			public virtual string CallbackParam 
			{ 
				get
				{
					return this.callbackParam;
				}
				set
				{
					this.callbackParam = value;
				}
			}

			private bool noCache = true;

			/// <summary>
			/// Whether a new request should abort any pending requests. (defaults to false)
			/// </summary>
			[DefaultValue(true)]
			public virtual bool NoCache 
			{ 
				get
				{
					return this.noCache;
				}
				set
				{
					this.noCache = value;
				}
			}

			private int timeout = 30000;

			/// <summary>
			/// (optional) The number of milliseconds to wait for a response. Defaults to 30 seconds.
			/// </summary>
			[DefaultValue(30000)]
			public virtual int Timeout 
			{ 
				get
				{
					return this.timeout;
				}
				set
				{
					this.timeout = value;
				}
			}

			private string url = "";

			/// <summary>
			/// The URL from which to request the data object.
			/// </summary>
			[DefaultValue("")]
			public virtual string Url 
			{ 
				get
				{
					return this.url;
				}
				set
				{
					this.url = value;
				}
			}

        }
    }
}