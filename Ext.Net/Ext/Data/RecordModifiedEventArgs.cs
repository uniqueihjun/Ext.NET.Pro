/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Formatting = Newtonsoft.Json.Formatting;

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
        public RecordModifiedEventArgs(JToken record)
        {
            this.record = record;
        }

        private JToken record;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public JToken Record
        {
            get { return record; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public T Object<T>()
		{
		    string json = this.Record.ToString(Formatting.None);
            
            JsonSerializer serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            StringReader sr = new StringReader(json);
            T obj = (T)serializer.Deserialize(sr, typeof(T));

            return obj;
        }
    }
}
