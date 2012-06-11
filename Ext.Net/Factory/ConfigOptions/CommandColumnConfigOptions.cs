/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
                
                list.Add("hideable", new ConfigOption("hideable", null, true, this.Hideable ));
                list.Add("commands", new ConfigOption("commands", new SerializationOptions("commands", JsonMode.AlwaysArray), null, this.Commands ));
                list.Add("groupCommands", new ConfigOption("groupCommands", new SerializationOptions("groupCommands", JsonMode.AlwaysArray), null, this.GroupCommands ));
                list.Add("prepareToolbar", new ConfigOption("prepareToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareToolbar ));
                list.Add("prepareGroupToolbar", new ConfigOption("prepareGroupToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareGroupToolbar ));
                list.Add("buttonAlign", new ConfigOption("buttonAlign", new SerializationOptions(JsonMode.ToLower), Alignment.Left, this.ButtonAlign ));

                return list;
            }
        }
    }
}