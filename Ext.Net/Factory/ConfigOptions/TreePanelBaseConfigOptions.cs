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
    public abstract partial class TreePanelBase
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
                
                list.Add("store", new ConfigOption("store", new SerializationOptions("store>Primary", 1), null, this.Store ));
                list.Add("fields", new ConfigOption("fields", new SerializationOptions(JsonMode.AlwaysArray), null, this.Fields ));
                list.Add("modelName", new ConfigOption("modelName", new SerializationOptions("model"), null, this.ModelName ));
                list.Add("model", new ConfigOption("model", new SerializationOptions("model>Primary", 2), null, this.Model ));
                list.Add("view", new ConfigOption("view", new SerializationOptions("viewConfig>View"), null, this.View ));
                list.Add("animate", new ConfigOption("animate", null, true, this.Animate ));
                list.Add("displayField", new ConfigOption("displayField", null, "text", this.DisplayField ));
                list.Add("folderSort", new ConfigOption("folderSort", null, null, this.FolderSort ));
                list.Add("lines", new ConfigOption("lines", null, true, this.Lines ));
                list.Add("root", new ConfigOption("root", new SerializationOptions("root>Primary", JsonMode.Object), null, this.Root ));
                list.Add("rootVisible", new ConfigOption("rootVisible", null, true, this.RootVisible ));
                list.Add("singleExpand", new ConfigOption("singleExpand", null, false, this.SingleExpand ));
                list.Add("useArrows", new ConfigOption("useArrows", null, false, this.UseArrows ));
                list.Add("columnLines", new ConfigOption("columnLines", null, true, this.ColumnLines ));
                list.Add("selectionSubmitConfig", new ConfigOption("selectionSubmitConfig", new SerializationOptions(JsonMode.Object), null, this.SelectionSubmitConfig ));
                list.Add("directEventConfig", new ConfigOption("directEventConfig", new SerializationOptions(JsonMode.Object), null, this.DirectEventConfig ));
                list.Add("mode", new ConfigOption("mode", new SerializationOptions(JsonMode.ToLower), TreePanelMode.Local, this.Mode ));
                list.Add("remoteJson", new ConfigOption("remoteJson", null, false, this.RemoteJson ));
                list.Add("localActions", new ConfigOption("localActions", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.LocalActions ));
                list.Add("noLeafIcon", new ConfigOption("noLeafIcon", null, false, this.NoLeafIcon ));

                return list;
            }
        }
    }
}