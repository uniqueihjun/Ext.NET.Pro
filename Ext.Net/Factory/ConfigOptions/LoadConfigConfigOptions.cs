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
    public partial class LoadConfig
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
                
                list.Add("mode", new ConfigOption("mode", new SerializationOptions(JsonMode.ToLower), LoadMode.Merge, this.Mode ));
                list.Add("passParentSize", new ConfigOption("passParentSize", null, false, this.PassParentSize ));
                list.Add("triggerEvent", new ConfigOption("triggerEvent", null, "", this.TriggerEvent ));
                list.Add("triggerControl", new ConfigOption("triggerControl", null, "", this.TriggerControl ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("manuallyTriggered", new ConfigOption("manuallyTriggered", null, false, this.ManuallyTriggered ));
                list.Add("reloadOnEvent", new ConfigOption("reloadOnEvent", null, false, this.ReloadOnEvent ));
                list.Add("showMask", new ConfigOption("showMask", null, false, this.ShowMask ));
                list.Add("maskMsg", new ConfigOption("maskMsg", null, "", this.MaskMsg ));
                list.Add("maskCls", new ConfigOption("maskCls", null, "", this.MaskCls ));
                list.Add("monitorComplete", new ConfigOption("monitorComplete", null, false, this.MonitorComplete ));

                return list;
            }
        }
    }
}