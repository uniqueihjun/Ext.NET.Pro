/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    public partial class TabStripItem
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("itemID", new ConfigOption("itemID", new SerializationOptions("id"), "", this.ItemID ));
                list.Add("actionItemProxy", new ConfigOption("actionItemProxy", new SerializationOptions("actionItem"), "", this.ActionItemProxy ));
                list.Add("hideMode", new ConfigOption("hideMode", new SerializationOptions(JsonMode.ToLower), HideMode.Display, this.HideMode ));
                list.Add("title", new ConfigOption("title", null, "", this.Title ));
                list.Add("tabTip", new ConfigOption("tabTip", null, "", this.TabTip ));
                list.Add("closable", new ConfigOption("closable", null, false, this.Closable ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls"), "", this.IconClsProxy ));
                list.Add("customConfig", new ConfigOption("customConfig", new SerializationOptions("-", typeof(CustomConfigJsonConverter)), null, this.CustomConfig ));

                return list;
            }
        }
    }
}