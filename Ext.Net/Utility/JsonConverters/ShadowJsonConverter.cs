/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class ShadowJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is ShadowMode)
            {
                ShadowMode shadow = (ShadowMode)value;
                switch (shadow)
                {
                    case ShadowMode.None:
                        writer.WriteValue(false);
                        break;
                    case ShadowMode.Sides:
                    case ShadowMode.Frame:
                    case ShadowMode.Drop:
                        writer.WriteValue(shadow.ToString().ToLowerInvariant());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
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

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof(ShadowMode).IsAssignableFrom(objectType);
        }
    }
}