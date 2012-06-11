/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using Newtonsoft.Json;
using Ext.Net.Utilities;
using System.ComponentModel;

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
		[Description("")]
        public XmlDocument XmlData
        {
            get
            {
                if (xmlData == null)
                {
                    RecordsToXmlConverter converter = new RecordsToXmlConverter();
                    
                    xmlData = (XmlDocument)JsonConvert.DeserializeObject(JsonData, typeof(XmlDocument), converter);
                }

                return xmlData;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ChangeRecords<T> ObjectData<T>()
        {
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
        public ConfirmationList BuildConfirmationList(string idColumnName)
        {
            if (idColumnName.IsEmpty())
            {
                return null;
            }

            ConfirmationList confirmationList = new ConfirmationList();

            XmlNodeList records = this.XmlData.SelectNodes("records/*/record");

            foreach (XmlNode node in records)
            {
                XmlNode keyNode = node.SelectSingleNode(idColumnName);

                if (keyNode.InnerText.IsEmpty())
                {
                    throw new InvalidOperationException("No id in submitted record");
                }

                confirmationList.Add(keyNode.InnerText, new ConfirmationRecord(false, keyNode.InnerText));
            }

            return confirmationList;
        }
    }
}
