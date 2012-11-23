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
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class KeyNav
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
                
                list.Add("componentEvent", new ConfigOption("componentEvent", null, false, this.ComponentEvent ));
                list.Add("defaultEventAction", new ConfigOption("defaultEventAction", null, EventAction.StopEvent, this.DefaultEventAction ));
                list.Add("disabled", new ConfigOption("disabled", null, false, this.Disabled ));
                list.Add("eventName", new ConfigOption("eventName", null, "", this.EventName ));
                list.Add("forceKeyDown", new ConfigOption("forceKeyDown", null, false, this.ForceKeyDown ));
                list.Add("componentElement", new ConfigOption("componentElement", new SerializationOptions("cmpEl"), "", this.ComponentElement ));
                list.Add("ignoreInputFields", new ConfigOption("ignoreInputFields", null, false, this.IgnoreInputFields ));
                list.Add("processEvent", new ConfigOption("processEvent", new SerializationOptions(JsonMode.Raw), null, this.ProcessEvent ));
                list.Add("processEventScope", new ConfigOption("processEventScope", new SerializationOptions(JsonMode.Raw), "", this.ProcessEventScope ));
                list.Add("targetProxy", new ConfigOption("targetProxy", new SerializationOptions("target", JsonMode.Raw), "", this.TargetProxy ));
                list.Add("space", new ConfigOption("space", new SerializationOptions(JsonMode.Raw), null, this.Space ));
                list.Add("left", new ConfigOption("left", new SerializationOptions(JsonMode.Raw), null, this.Left ));
                list.Add("right", new ConfigOption("right", new SerializationOptions(JsonMode.Raw), null, this.Right ));
                list.Add("up", new ConfigOption("up", new SerializationOptions(JsonMode.Raw), null, this.Up ));
                list.Add("down", new ConfigOption("down", new SerializationOptions(JsonMode.Raw), null, this.Down ));
                list.Add("pageUp", new ConfigOption("pageUp", new SerializationOptions(JsonMode.Raw), null, this.PageUp ));
                list.Add("pageDown", new ConfigOption("pageDown", new SerializationOptions(JsonMode.Raw), null, this.PageDown ));
                list.Add("del", new ConfigOption("del", new SerializationOptions(JsonMode.Raw), null, this.Del ));
                list.Add("home", new ConfigOption("home", new SerializationOptions(JsonMode.Raw), null, this.Home ));
                list.Add("end", new ConfigOption("end", new SerializationOptions(JsonMode.Raw), null, this.End ));
                list.Add("enter", new ConfigOption("enter", new SerializationOptions(JsonMode.Raw), null, this.Enter ));
                list.Add("esc", new ConfigOption("esc", new SerializationOptions(JsonMode.Raw), null, this.Esc ));
                list.Add("tab", new ConfigOption("tab", new SerializationOptions(JsonMode.Raw), null, this.Tab ));

                return list;
            }
        }
    }
}