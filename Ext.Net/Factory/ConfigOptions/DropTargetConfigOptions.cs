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
    public partial class DropTarget
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
                
                list.Add("group", new ConfigOption("group", new SerializationOptions("ddGroup"), "", this.Group ));
                list.Add("dropAllowed", new ConfigOption("dropAllowed", null, "x-dd-drop-ok", this.DropAllowed ));
                list.Add("dropNotAllowed", new ConfigOption("dropNotAllowed", null, "x-dd-drop-nodrop", this.DropNotAllowed ));
                list.Add("overClass", new ConfigOption("overClass", null, "", this.OverClass ));
                list.Add("containerScroll", new ConfigOption("containerScroll", null, false, this.ContainerScroll ));
                list.Add("notifyDrop", new ConfigOption("notifyDrop", new SerializationOptions(JsonMode.Raw), null, this.NotifyDrop ));
                list.Add("notifyEnter", new ConfigOption("notifyEnter", new SerializationOptions(JsonMode.Raw), null, this.NotifyEnter ));
                list.Add("notifyOut", new ConfigOption("notifyOut", new SerializationOptions(JsonMode.Raw), null, this.NotifyOut ));
                list.Add("notifyOver", new ConfigOption("notifyOver", new SerializationOptions(JsonMode.Raw), null, this.NotifyOver ));

                return list;
            }
        }
    }
}