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
    public partial class DragSource
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
                list.Add("dragDataProxy", new ConfigOption("dragDataProxy", new SerializationOptions("dragData", JsonMode.Raw), "", this.DragDataProxy ));
                list.Add("animRepair", new ConfigOption("animRepair", null, true, this.AnimRepair ));
                list.Add("dropAllowed", new ConfigOption("dropAllowed", null, "x-dd-drop-ok", this.DropAllowed ));
                list.Add("dropNotAllowed", new ConfigOption("dropNotAllowed", null, "x-dd-drop-nodrop", this.DropNotAllowed ));
                list.Add("repairHighlightColor", new ConfigOption("repairHighlightColor", null, "c3daf9", this.RepairHighlightColor ));
                list.Add("afterDragDrop", new ConfigOption("afterDragDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterDragDrop ));
                list.Add("afterDragEnter", new ConfigOption("afterDragEnter", new SerializationOptions(JsonMode.Raw), null, this.AfterDragEnter ));
                list.Add("afterDragOut", new ConfigOption("afterDragOut", new SerializationOptions(JsonMode.Raw), null, this.AfterDragOut ));
                list.Add("afterDragOver", new ConfigOption("afterDragOver", new SerializationOptions(JsonMode.Raw), null, this.AfterDragOver ));
                list.Add("afterInvalidDrop", new ConfigOption("afterInvalidDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterInvalidDrop ));
                list.Add("afterValidDrop", new ConfigOption("afterValidDrop", new SerializationOptions(JsonMode.Raw), null, this.AfterValidDrop ));
                list.Add("beforeDragDrop", new ConfigOption("beforeDragDrop", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragDrop ));
                list.Add("beforeDragEnter", new ConfigOption("beforeDragEnter", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragEnter ));
                list.Add("beforeDragOut", new ConfigOption("beforeDragOut", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragOut ));
                list.Add("beforeDragOver", new ConfigOption("beforeDragOver", new SerializationOptions(JsonMode.Raw), null, this.BeforeDragOver ));
                list.Add("beforeInvalidDrop", new ConfigOption("beforeInvalidDrop", new SerializationOptions(JsonMode.Raw), null, this.BeforeInvalidDrop ));
                list.Add("onBeforeDrag", new ConfigOption("onBeforeDrag", new SerializationOptions(JsonMode.Raw), null, this.OnBeforeDrag ));
                list.Add("onStartDrag", new ConfigOption("onStartDrag", new SerializationOptions(JsonMode.Raw), null, this.OnStartDrag ));
                list.Add("getDragData", new ConfigOption("getDragData", new SerializationOptions(JsonMode.Raw), null, this.GetDragData ));

                return list;
            }
        }
    }
}