/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class ClickRepeater
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
                
                list.Add("accelerate", new ConfigOption("accelerate", null, false, this.Accelerate ));
                list.Add("delay", new ConfigOption("delay", new SerializationOptions(JsonMode.Raw), 250, this.Delay ));
                list.Add("targetProxy", new ConfigOption("targetProxy", new SerializationOptions("el", JsonMode.Raw), "", this.TargetProxy ));
                list.Add("interval", new ConfigOption("interval", new SerializationOptions(JsonMode.Raw), 20, this.Interval ));
                list.Add("pressedCls", new ConfigOption("pressedCls", null, "", this.PressedCls ));
                list.Add("preventDefault", new ConfigOption("preventDefault", null, false, this.PreventDefault ));
                list.Add("stopDefault", new ConfigOption("stopDefault", null, false, this.StopDefault ));
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(JsonMode.Raw), "", this.Handler ));
                list.Add("ignoredButtons", new ConfigOption("ignoredButtons", new SerializationOptions(JsonMode.Raw), "", this.IgnoredButtons ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}