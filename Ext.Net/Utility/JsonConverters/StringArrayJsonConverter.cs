/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StringArrayJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            return typeof(string[]).IsAssignableFrom(valueType);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is string[])
            {
                writer.WriteRawValue("[{0}]".FormatWith(((string[])value).Join(",", "\"{0}\"")));
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}