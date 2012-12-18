/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class EnumToIntConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            Type u = Nullable.GetUnderlyingType(valueType);

            if (u != null)
            {
                valueType = u;
            }
            
            return valueType.IsEnum;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(Convert.ToInt32(value as Enum).ToString());
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (Enum.IsDefined(objectType, (int)reader.Value))
            {
                return Enum.ToObject(objectType, (int)reader.Value);
            }

            throw new InvalidEnumArgumentException("The value \"" + reader.Value.ToString() + "\" cannot be converted to an Enum type of " + objectType.Name + ".");
        }
    }
}