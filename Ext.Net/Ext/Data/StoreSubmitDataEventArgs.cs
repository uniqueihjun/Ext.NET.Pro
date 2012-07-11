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
using System.Xml;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreSubmitDataEventArgs : EventArgs
    {
        private readonly JToken parameters;
        private readonly string json;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreSubmitDataEventArgs() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreSubmitDataEventArgs(string json, JToken parameters)
        {
            this.parameters = parameters;
            this.json = json;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Json
        {
            get
            {
                return this.json;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlNode Xml
        {
            get
            {
                return JsonConvert.DeserializeXmlNode("{records:{record:" + json + "}}");
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Object<T>()
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        private ParameterCollection p;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection Parameters
        {
            get
            {
                if (p != null)
                {
                    return p;
                }

                if (this.parameters == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.JTokenToParams(this.parameters);

                return p;
            }
        }
    }
}