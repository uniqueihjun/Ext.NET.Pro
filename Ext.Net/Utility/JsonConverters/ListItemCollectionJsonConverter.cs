/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Text;
using System.Web.UI.WebControls;

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
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ListItemCollection<ListItem> items = value as ListItemCollection<ListItem>;

            StringBuilder sb = new StringBuilder("new Ext.data.SimpleStore({fields:[\"text\",\"value\"],data :[");

            if (items != null && items.Count > 0)
            {
                foreach (ListItem item in items)
                {
                    sb.Append("[");
                    sb.Append(JSON.Serialize(item.Text));
                    sb.Append(",");
                    sb.Append(JSON.Serialize(item.Value));
                    sb.Append("],");
                }
                sb.Remove(sb.Length - 1, 1);
            }
            
            sb.Append("]})");

            writer.WriteRawValue(sb.ToString());
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof(ListItemCollection<ListItem>).IsAssignableFrom(objectType);
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
