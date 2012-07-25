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
using System.IO;
using System.Web;
using System.Xml;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreDataHandler
    {
        private string jsonData;
        private XmlDocument xmlData;
        private readonly HttpContext context;
        private bool isBatch;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler(HttpContext context)
        {
            this.context = context;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler(string jsonData)
        {
            if (jsonData == null)
            {
                throw new ArgumentNullException("jsonData");
            }
            this.jsonData = jsonData;
            this.isBatch = this.jsonData.IsNotEmpty() && this.jsonData[0] == '{' && this.jsonData[this.jsonData.Length - 1] == '}';
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string JsonData
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
        public bool IsBatch
        {
            get
            {
                return this.isBatch;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlDocument XmlData
        {
            get
            {
                if (xmlData == null)
                {
                    if (this.isBatch)
                    {
                        RecordsToXmlConverter converter = new RecordsToXmlConverter();
                        xmlData = (XmlDocument)JsonConvert.DeserializeObject(JsonData, typeof(XmlDocument), converter);
                    }
                    else
                    {
                        xmlData = JsonConvert.DeserializeXmlNode("{records:{record:" + JsonData + "}}");
                    }
                }

                return xmlData;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ChangeRecords<T> BatchObjectData<T>()
        {
            if (!this.IsBatch)
            {
                throw new Exception("The data is not batch");
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            StringReader sr = new StringReader(JsonData);
            ChangeRecords<T> data = (ChangeRecords<T>)serializer.Deserialize(sr, typeof(ChangeRecords<T>));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public List<T> ObjectData<T>()
        {
            if (this.IsBatch)
            {
                throw new Exception("The data is batch");
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            StringReader sr = new StringReader(JsonData);
            List<T> data = (List<T>)serializer.Deserialize(sr, typeof(List<T>));

            return data;
        }
    }
}
