/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Text;
using System.Web.UI.WebControls;
using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ListItemCollectionJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            ListItemCollection items = value as ListItemCollection;

            //StringBuilder sb = new StringBuilder("new Ext.data.SimpleStore({fields:[\"text\",\"value\"],data :[");
            StringBuilder sb = new StringBuilder("[");

            if (items != null && items.Count > 0)
            {
                foreach (ListItem item in items)
                {
                    sb.Append("[");
                    var val = item.Value.IsEmpty() ? item.Text : item.Value;
                    sb.Append(item.Mode == ParameterMode.Value ? JSON.Serialize(val) : val);
                    sb.Append(",");
                    sb.Append(item.Text.IsEmpty() ? JSON.Serialize(item.Value) : JSON.Serialize(item.Text));
                    sb.Append("],");
                }
                sb.Remove(sb.Length - 1, 1);
            }
            
            //sb.Append("]})");
            sb.Append("]");

            writer.WriteRawValue(sb.ToString());
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof(ListItemCollection).IsAssignableFrom(objectType);
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
