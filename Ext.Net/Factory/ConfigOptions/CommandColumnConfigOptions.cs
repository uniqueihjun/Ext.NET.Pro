/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class CommandColumn
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
                
                list.Add("hideable", new ConfigOption("hideable", null, false, this.Hideable ));
                list.Add("menuDisabled", new ConfigOption("menuDisabled", null, true, this.MenuDisabled ));
                list.Add("overOnly", new ConfigOption("overOnly", null, false, this.OverOnly ));
                list.Add("showDelay", new ConfigOption("showDelay", null, 250, this.ShowDelay ));
                list.Add("hideDelay", new ConfigOption("hideDelay", null, 500, this.HideDelay ));
                list.Add("commands", new ConfigOption("commands", new SerializationOptions("commands", JsonMode.AlwaysArray), null, this.Commands ));
                list.Add("groupCommands", new ConfigOption("groupCommands", new SerializationOptions("groupCommands", JsonMode.AlwaysArray), null, this.GroupCommands ));
                list.Add("prepareToolbar", new ConfigOption("prepareToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareToolbar ));
                list.Add("prepareGroupToolbar", new ConfigOption("prepareGroupToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareGroupToolbar ));
                list.Add("pack", new ConfigOption("pack", new SerializationOptions(JsonMode.ToLower), BoxPack.Start, this.Pack ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}