/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ListenerJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            return typeof(ComponentListener).IsAssignableFrom(valueType);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null && value is ComponentListener)
            {
                ComponentListener componentListener = (ComponentListener)value;

                if (!componentListener.IsDefault)
                {
                    if (this.Owner is StateManagedItem)
                    {
                        componentListener.Owner = ((StateManagedItem)this.Owner).Owner;
                    }
                    else if (this.Owner is Control) 
                    {
                        componentListener.Owner = (Control)this.Owner;
                    }

                    componentListener.SetArgumentList(this.Owner.GetType().GetProperty(this.PropertyName));
                    
                    writer.WriteRawValue(new ClientConfig().Serialize(componentListener));
                    return;
                }
            }
            writer.WriteRawValue("{}");
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