/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;

using Newtonsoft.Json;
using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LoadMaskJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            LoadMask mask = value as LoadMask;

            if (mask != null && mask.ShowMask)
            {
                string jsonMask = new ClientConfig().Serialize(mask);

                if (jsonMask.IsEmpty() || jsonMask.Equals("{}"))
                {
                    writer.WriteValue(true);
                }
                else
                {
                    writer.WriteRawValue(jsonMask);
                }
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof(string).IsAssignableFrom(objectType);
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