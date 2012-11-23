/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class StatusBar
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
                
                list.Add("autoClear", new ConfigOption("autoClear", null, 5000, this.AutoClear ));
                list.Add("busyIconClsProxy", new ConfigOption("busyIconClsProxy", new SerializationOptions("busyIconCls"), "", this.BusyIconClsProxy ));
                list.Add("busyIconCls", new ConfigOption("busyIconCls", null, "x-status-busy", this.BusyIconCls ));
                list.Add("busyText", new ConfigOption("busyText", null, "Loading...", this.BusyText ));
                list.Add("cls", new ConfigOption("cls", null, "x-statusbar", this.Cls ));
                list.Add("defaultIconClsProxy", new ConfigOption("defaultIconClsProxy", new SerializationOptions("defaultIconCls"), "", this.DefaultIconClsProxy ));
                list.Add("defaultIconCls", new ConfigOption("defaultIconCls", null, "", this.DefaultIconCls ));
                list.Add("defaultText", new ConfigOption("defaultText", null, "&nbsp;", this.DefaultText ));
                list.Add("iconClsProxy", new ConfigOption("iconClsProxy", new SerializationOptions("iconCls"), "", this.IconClsProxy ));
                list.Add("statusAlign", new ConfigOption("statusAlign", new SerializationOptions(JsonMode.ToLower), StatusAlign.Left, this.StatusAlign ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}