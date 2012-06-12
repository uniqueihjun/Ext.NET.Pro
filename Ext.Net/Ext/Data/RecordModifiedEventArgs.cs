/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class RecordModifiedEventArgs : EventArgs
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public RecordModifiedEventArgs(XmlNode record)
        {
            this.record = record;
        }

        private XmlNode record;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlNode Record
        {
            get { return record; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public T Object<T>()
        {
            string json = JsonConvert.SerializeXmlNode(this.Record);
            json = json.Substring(10, json.Length - 11);

            JsonSerializer serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            StringReader sr = new StringReader(json);
            T obj = (T)serializer.Deserialize(sr, typeof(T));

            return obj;
        }
    }
}
