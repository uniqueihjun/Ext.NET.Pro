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
    public partial class BaseListener
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
                
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "this", this.Scope ));
                list.Add("delegate", new ConfigOption("delegate", null, "", this.Delegate ));
                list.Add("stopEvent", new ConfigOption("stopEvent", null, false, this.StopEvent ));
                list.Add("preventDefault", new ConfigOption("preventDefault", null, false, this.PreventDefault ));
                list.Add("stopPropagation", new ConfigOption("stopPropagation", null, false, this.StopPropagation ));
                list.Add("normalized", new ConfigOption("normalized", null, false, this.Normalized ));
                list.Add("delay", new ConfigOption("delay", null, 20, this.Delay ));
                list.Add("single", new ConfigOption("single", null, false, this.Single ));
                list.Add("buffer", new ConfigOption("buffer", null, 0, this.Buffer ));

                return list;
            }
        }
    }
}