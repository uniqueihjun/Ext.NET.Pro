/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ConfigBagJsonConverter : ExtJsonConverter
    {
        /// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
#if NET40
            DynamicConfigDictionary config = (DynamicConfigDictionary)value;

            if (config != null)
            {
                IEnumerable<string> keys = config.GetDynamicMemberNames();  
                
                foreach (string key in keys)
                {
                    writer.WritePropertyName(Ext.Net.Utilities.StringUtils.ToLowerCamelCase(key));
                    writer.WriteRawValue(JSON.Serialize(config.GetDynamicValue(key), new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()));
                }
            }
#endif
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
#if NET40
            return typeof(DynamicConfigDictionary).IsAssignableFrom(objectType);
#else
            return false;
#endif
        }
    }
}
