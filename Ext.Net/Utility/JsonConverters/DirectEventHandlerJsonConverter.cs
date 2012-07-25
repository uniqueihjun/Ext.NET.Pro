/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class DirectEventHandlerJsonConverter : ExtJsonConverter
    {
        private static Regex Value_RE = new Regex(@"^(\w+.\w+)$", RegexOptions.Compiled);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer">Serializer</param>
        [Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is string)
            {
                if (Value_RE.Match(value.ToString()).Success) 
                {
                    writer.WriteRawValue(value.ToString()); 
                }
                else
                {
                    string prms;
                    
                    switch (this.Name)
                    {
                        case "before":
                            prms = "el,type,action,extraParams,o";
                            break;
                        case "complete":
                            prms = "success,response,result,el,type,action,extraParams,o";
                            break;
                        default:
                            prms = "response,result,el,type,action,extraParams,o";
                            break;
                    }

                    value = TokenUtils.ReplaceRawToken(TokenUtils.ParseTokens(value.ToString(), this.OwnerControl));
                    writer.WriteRawValue(new JFunction((string)value, prms).ToScript()); 
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        [Description("")]
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        [Description("")]
        public override bool CanConvert(Type objectType)
        {
            return typeof(string).IsAssignableFrom(objectType);
        }
    }
}
