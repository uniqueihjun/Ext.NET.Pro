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
    public partial class ImageCommandColumn
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
                list.Add("rightCommandAlign", new ConfigOption("rightCommandAlign", new SerializationOptions(JsonMode.Ignore), false, this.RightCommandAlign ));
                list.Add("groupCommands", new ConfigOption("groupCommands", new SerializationOptions("groupCommands", JsonMode.AlwaysArray), null, this.GroupCommands ));
                list.Add("isCellCommand", new ConfigOption("isCellCommand", new SerializationOptions(JsonMode.Ignore), false, this.IsCellCommand ));
                list.Add("prepareGroupCommand", new ConfigOption("prepareGroupCommand", new SerializationOptions(JsonMode.Raw), null, this.PrepareGroupCommand ));
                list.Add("prepareGroupCommands", new ConfigOption("prepareGroupCommands", new SerializationOptions(JsonMode.Raw), null, this.PrepareGroupCommands ));
                list.Add("prepareCommand", new ConfigOption("prepareCommand", new SerializationOptions(JsonMode.Raw), null, this.PrepareCommand ));
                list.Add("prepareCommands", new ConfigOption("prepareCommands", new SerializationOptions(JsonMode.Raw), null, this.PrepareCommands ));

                return list;
            }
        }
    }
}