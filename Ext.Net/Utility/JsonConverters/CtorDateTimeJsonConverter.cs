/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class CtorDateTimeJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            return (typeof(DateTime).IsAssignableFrom(valueType)
              || typeof(DateTime?).IsAssignableFrom(valueType));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime || value is DateTime?)
            {
                DateTime date = value is DateTime ? (DateTime)value : (value as DateTime?).Value;

                if (date.Equals(DateTime.MinValue))
                {
                    writer.WriteRawValue("null");
                }
                else
                {
                    string template = (date.TimeOfDay == new TimeSpan(0, 0, 0)) ? "{0},{1},{2}" : "{0},{1},{2},{3},{4},{5},{6}";

                    writer.WriteStartConstructor("Date");
                    writer.WriteRawValue(
                        string.Format(template, date.Year, date.Month - 1, date.Day,
                                      date.Hour, date.Minute, date.Second, date.Millisecond));
                    writer.WriteEndConstructor();
                }
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