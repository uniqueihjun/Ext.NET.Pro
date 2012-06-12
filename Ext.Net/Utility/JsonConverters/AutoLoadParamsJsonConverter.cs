/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Text;

using Ext.Net.Utilities;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AutoLoadParamsJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ParameterCollection parameters = value as ParameterCollection;

            if (parameters != null)
            {
                StringBuilder sb = new StringBuilder("{params:{");

                foreach (Parameter parameter in parameters)
                {
                    sb.Append(parameter.ToString()).Append(",");
                }
                if (sb[sb.Length-1] == ',')
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("}}");

                writer.WriteRawValue(sb.ToString());
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new System.NotImplementedException();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof (ParameterCollection).IsAssignableFrom(objectType);
        }
    }
}
