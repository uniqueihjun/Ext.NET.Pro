/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class Tool
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
                
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), ToolType.None, this.Type ));
                list.Add("customType", new ConfigOption("customType", new SerializationOptions("type"), "", this.CustomType ));
                list.Add("fnProxy", new ConfigOption("fnProxy", new SerializationOptions("handler", JsonMode.Raw), "", this.FnProxy ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "this", this.Scope ));
                list.Add("stopEvent", new ConfigOption("stopEvent", null, true, this.StopEvent ));
                list.Add("toolTip", new ConfigOption("toolTip", new SerializationOptions("tooltip"), "", this.ToolTip ));
                list.Add("tooltipConfig", new ConfigOption("tooltipConfig", new SerializationOptions("tooltip", JsonMode.Object), null, this.TooltipConfig ));
                list.Add("toolTipType", new ConfigOption("toolTipType", new SerializationOptions("tooltipType"), ToolTipType.Qtip, this.ToolTipType ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}