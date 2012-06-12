/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class KeyBinding
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
                
                list.Add("shift", new ConfigOption("shift", null, null, this.Shift ));
                list.Add("ctrl", new ConfigOption("ctrl", null, null, this.Ctrl ));
                list.Add("alt", new ConfigOption("alt", null, null, this.Alt ));
                list.Add("stopEvent", new ConfigOption("stopEvent", null, false, this.StopEvent ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("listenerProxy", new ConfigOption("listenerProxy", new SerializationOptions("fn", JsonMode.Raw), "", this.ListenerProxy ));
                list.Add("keysProxy", new ConfigOption("keysProxy", new SerializationOptions("key", JsonMode.Raw), "", this.KeysProxy ));

                return list;
            }
        }
    }
}