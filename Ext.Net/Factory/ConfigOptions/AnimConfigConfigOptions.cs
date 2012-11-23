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
    public partial class AnimConfig
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
                
                list.Add("alternate", new ConfigOption("alternate", null, false, this.Alternate ));
                list.Add("callback", new ConfigOption("callback", new SerializationOptions(JsonMode.Raw), "", this.Callback ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("delay", new ConfigOption("delay", null, 0, this.Delay ));
                list.Add("duration", new ConfigOption("duration", null, 250, this.Duration ));
                list.Add("dynamic", new ConfigOption("dynamic", null, false, this.Dynamic ));
                list.Add("easingProxy", new ConfigOption("easingProxy", new SerializationOptions("easing"), "", this.EasingProxy ));
                list.Add("from", new ConfigOption("from", new SerializationOptions(JsonMode.ArrayToObject), null, this.From ));
                list.Add("iterations", new ConfigOption("iterations", null, 1, this.Iterations ));
                list.Add("keyFramesProxy", new ConfigOption("keyFramesProxy", new SerializationOptions("keyframes", JsonMode.Raw), null, this.KeyFramesProxy ));
                list.Add("reverse", new ConfigOption("reverse", null, false, this.Reverse ));
                list.Add("to", new ConfigOption("to", new SerializationOptions(JsonMode.ArrayToObject), null, this.To ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));

                return list;
            }
        }
    }
}