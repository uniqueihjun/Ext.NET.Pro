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
using System.Web;
using System.Xml;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SubmitHandler
    {
        private string jsonData;
        private readonly HttpContext context;

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public SubmitHandler()
        {
            this.context = HttpContext.Current;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SubmitHandler(HttpContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonData"></param>
        [Description("")]
        public SubmitHandler(string jsonData)
        {
            if (jsonData == null)
            {
                throw new ArgumentNullException("jsonData");
            }
            this.jsonData = jsonData;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Json
        {
            get
            {
                if (jsonData == null)
                {
                    jsonData = context.Request["data"];
                }

                return jsonData;
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
                return JsonConvert.DeserializeXmlNode("{records:{record:" + this.Json + "}}");
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Object<T>()
        {
            return JsonConvert.DeserializeObject<List<T>>(this.Json);
        }
    }
}