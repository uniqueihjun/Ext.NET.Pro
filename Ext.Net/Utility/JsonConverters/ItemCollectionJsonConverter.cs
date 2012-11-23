/********
 * @version   : 2.1.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections;
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
    public partial class ItemCollectionJsonConverter : ExtJsonConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvert(Type valueType)
        {
            return typeof(ItemCollection).IsAssignableFrom(valueType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSingleItemArray()
        {
            return false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, JsonSerializer serializer)
        {
            IList items = (IList)value;

            if (value != null && items.Count > 0)
            {
                if (items.Count == 1 && this.IsSingleItemArray())
                {
                    Control item = (Control)items[0];

                    if (!item.Visible)
                    {
                        writer.WriteNull();
                        return;
                    }

                    if (!(item is IProxyContainer))
                    {
                        writer.WriteRawValue(this.Format(items[0] as Control));
                    }
                    else
                    {
                        List<string> ids = ((IProxyContainer)item).GetIDS();

                        if (ids != null && ids.Count > 0)
                        {
                            if (ids.Count == 1)
                            {
                                writer.WriteRawValue(this.Format(ids[0]));
                            }
                            else
                            {
                                writer.WriteStartArray();

                                foreach (string id in ids)
                                {
                                    writer.WriteRawValue(this.Format(id));
                                }

                                writer.WriteEndArray();
                            }
                        }
                    }
                }
                else
                {
                    bool visible = false;

                    foreach (Observable item in items)
                    {
                        if (item.Visible)
                        {
                            visible = true;
                        }
                    }

                    if (visible)
                    {
                        writer.WriteStartArray();

                        foreach (Observable item in items)
                        {
                            if (item.Visible)
                            {
                                if (!(item is IProxyContainer))
                                {
                                    writer.WriteRawValue(this.Format(item));
                                }
                                else
                                {
                                    List<string> ids = ((IProxyContainer)item).GetIDS();

                                    if (ids != null && ids.Count > 0)
                                    {
                                        foreach (string id in ids)
                                        {
                                            writer.WriteRawValue(this.Format(id));
                                        }
                                    }
                                }                                
                            }
                        }

                        writer.WriteEndArray();
                    }
                    else
                    {
                        writer.WriteNull();
                    }
                }
            }
        }

        protected virtual string Format(Control control)
        {
            bool islazy = false;
            string clientID = control.ClientID;

            if (control != null && control is Observable)
            {
                Observable o = (Observable)control;
                
                islazy = o.IsLazy;
                clientID = o.BaseClientID;
            }

            return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{                        
                            {"id", islazy ? clientID + "_ClientInit" : clientID}                            
                        });
        }

        protected virtual string Format(string id)
        {
            return Transformer.NET.Net.CreateToken(typeof(Transformer.NET.AnchorTag), new Dictionary<string, string>{                        
                            {"id", id}                            
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

    /// <summary>
    /// 
    /// </summary>
    public class SingleItemCollectionJsonConverter : ItemCollectionJsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override bool IsSingleItemArray()
        {
            return true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class FunctionItemCollectionJsonConverter : SingleItemCollectionJsonConverter
    {
        protected override string Format(Control control)
        {
            return string.Concat("function(){return ", base.Format(control), ";}");
        }
    }
}