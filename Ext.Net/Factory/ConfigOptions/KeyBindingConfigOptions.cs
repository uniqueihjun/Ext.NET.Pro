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
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(typeof(FunctionJsonConverter)), "", this.Handler ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("defaultEventAction", new ConfigOption("defaultEventAction", new SerializationOptions(JsonMode.ToCamelLower), EventAction.None, this.DefaultEventAction ));
                list.Add("keysStringProxy", new ConfigOption("keysStringProxy", new SerializationOptions("key", JsonMode.Raw), "", this.KeysStringProxy ));
                list.Add("keysProxy", new ConfigOption("keysProxy", new SerializationOptions("key", JsonMode.Raw), "", this.KeysProxy ));

                return list;
            }
        }
    }
}