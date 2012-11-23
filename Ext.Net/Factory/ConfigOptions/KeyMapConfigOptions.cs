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
    public partial class KeyMap
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
                
                list.Add("bindingProxy", new ConfigOption("bindingProxy", new SerializationOptions("binding", JsonMode.Raw), "", this.BindingProxy ));
                list.Add("eventName", new ConfigOption("eventName", null, "", this.EventName ));
                list.Add("componentEvent", new ConfigOption("componentEvent", null, false, this.ComponentEvent ));
                list.Add("componentElement", new ConfigOption("componentElement", new SerializationOptions("cmpEl"), "", this.ComponentElement ));
                list.Add("ignoreInputFields", new ConfigOption("ignoreInputFields", null, false, this.IgnoreInputFields ));
                list.Add("processEvent", new ConfigOption("processEvent", new SerializationOptions(JsonMode.Raw), null, this.ProcessEvent ));
                list.Add("processEventScope", new ConfigOption("processEventScope", new SerializationOptions(JsonMode.Raw), "", this.ProcessEventScope ));
                list.Add("targetProxy", new ConfigOption("targetProxy", new SerializationOptions("target", JsonMode.Raw), "", this.TargetProxy ));

                return list;
            }
        }
    }
}