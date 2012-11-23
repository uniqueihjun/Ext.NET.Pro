/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LazyControlJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            return typeof(Control).IsAssignableFrom(valueType);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            Control control = value as Control;

            if (control != null)
            {
                if (!control.Visible)
                {
                    writer.WriteNull();
                    return;
                }

                writer.WriteRawValue(this.Format(control));
            }
        }

        protected virtual string Format(Control control)
        {
            bool islazy = false;
            Observable observable = control as Observable;
            string clientID = control.ClientID;

            if (observable != null)
            {
                islazy = observable.IsLazy;
                clientID = observable.BaseClientID;
            }           

            return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{                        
                            {"id", islazy ? clientID + "_ClientInit" : clientID}                            
                        });
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

    public partial class FunctionLazyControlJsonConverter : LazyControlJsonConverter
    {
        protected override string Format(Control control)
        {
            return string.Concat("function(){return ", base.Format(control), ";}");
        }
    }
}