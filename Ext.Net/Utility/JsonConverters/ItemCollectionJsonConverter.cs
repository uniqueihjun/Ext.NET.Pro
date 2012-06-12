/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.ComponentModel;
using System.Collections;
using System.Web.UI;

using Ext.Net.Utilities;
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

        private static bool CanBeSingleItemArray(object item)
        {
            return item is ButtonBase || item is CheckboxBase;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            IList items = (IList)value;

            if (value != null && items.Count > 0)
            {
                if (items.Count == 1 && !CanBeSingleItemArray(items[0]))
                {
                    Control item = (Control)items[0];

                    PanelBase pnl = item as PanelBase;

                    if (!item.Visible || (pnl != null && pnl.Hidden && pnl.ParentComponent is TabPanel))
                    {
                        writer.WriteNull();
                        return;
                    }

                    writer.WriteRawValue(this.Format(items[0] as Control));
                }
                else
                {
                    bool visible = false;

                    foreach (Observable item in items)
                    {
                        PanelBase pnl = item as PanelBase;
                        bool isTab = pnl != null && pnl.ParentComponent is TabPanel;

                        if (item.Visible && (!isTab || !pnl.Hidden))
                        {
                            visible = true;
                        }
                    }

                    if (visible)
                    {
                        writer.WriteStartArray();

                        foreach (Observable item in items)
                        {
                            PanelBase pnl = item as PanelBase;

                            bool isTab = pnl != null && pnl.ParentComponent is TabPanel;

                            if (item.Visible && (!isTab || !pnl.Hidden))
                            {
                                writer.WriteRawValue(this.Format(item));
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

        private string Format(Control control)
        {
            bool islazy = false;

            if (control != null && control is Observable)
            {
                islazy = (control as Observable).IsLazy;
            }

            string template = islazy ? "{{{0}_ClientInit}}" : "{0}";

            return template.FormatWith(control.ClientID);
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