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
                
                list.Add("allowLeafDrop", new ConfigOption("allowLeafDrop", null, false, this.AllowLeafDrop ));
                list.Add("animate", new ConfigOption("animate", null, true, this.Animate ));
                list.Add("containerScroll", new ConfigOption("containerScroll", null, false, this.ContainerScroll ));
                list.Add("dDAppendOnly", new ConfigOption("dDAppendOnly", new SerializationOptions("ddAppendOnly"), false, this.DDAppendOnly ));
                list.Add("dDGroup", new ConfigOption("dDGroup", new SerializationOptions("ddGroup"), "", this.DDGroup ));
                list.Add("dDScroll", new ConfigOption("dDScroll", new SerializationOptions("ddScroll"), false, this.DDScroll ));
                list.Add("dragConfigProxy", new ConfigOption("dragConfigProxy", new SerializationOptions("dragConfig", JsonMode.Raw), "", this.DragConfigProxy ));
                list.Add("dropConfigProxy", new ConfigOption("dropConfigProxy", new SerializationOptions("dropConfig", JsonMode.Raw), "", this.DropConfigProxy ));
                list.Add("enableDD", new ConfigOption("enableDD", null, false, this.EnableDD ));
                list.Add("enableDrag", new ConfigOption("enableDrag", null, false, this.EnableDrag ));
                list.Add("enableDrop", new ConfigOption("enableDrop", null, false, this.EnableDrop ));
                list.Add("highlightColor", new ConfigOption("highlightColor", new SerializationOptions("hlColor"), "C3DAF9", this.HighlightColor ));
                list.Add("highlightDrop", new ConfigOption("highlightDrop", new SerializationOptions("hlDrop"), true, this.HighlightDrop ));
                list.Add("lines", new ConfigOption("lines", null, true, this.Lines ));
                list.Add("pathSeparator", new ConfigOption("pathSeparator", null, "/", this.PathSeparator ));
                list.Add("activeEditor", new ConfigOption("activeEditor", null, "", this.ActiveEditor ));
                list.Add("loader", new ConfigOption("loader", new SerializationOptions("loader>Primary"), null, this.Loader ));
                list.Add("rootVisible", new ConfigOption("rootVisible", null, true, this.RootVisible ));
                list.Add("selectionModel", new ConfigOption("selectionModel", new SerializationOptions("selModel>Primary"), null, this.SelectionModel ));
                list.Add("singleExpand", new ConfigOption("singleExpand", null, false, this.SingleExpand ));
                list.Add("trackMouseOver", new ConfigOption("trackMouseOver", null, true, this.TrackMouseOver ));
                list.Add("useArrows", new ConfigOption("useArrows", null, false, this.UseArrows ));
                list.Add("noLeafIcon", new ConfigOption("noLeafIcon", null, false, this.NoLeafIcon ));
                list.Add("editors", new ConfigOption("editors", new SerializationOptions("editors", typeof(ItemCollectionJsonConverter)), null, this.Editors ));
                list.Add("selectionSubmitConfig", new ConfigOption("selectionSubmitConfig", new SerializationOptions(JsonMode.Object), null, this.SelectionSubmitConfig ));
                list.Add("sorter", new ConfigOption("sorter", new SerializationOptions(JsonMode.Object), null, this.Sorter ));
                list.Add("directEventConfig", new ConfigOption("directEventConfig", new SerializationOptions(JsonMode.Object), null, this.DirectEventConfig ));
                list.Add("mode", new ConfigOption("mode", new SerializationOptions(JsonMode.ToLower), TreePanelMode.Local, this.Mode ));
                list.Add("remoteJson", new ConfigOption("remoteJson", null, false, this.RemoteJson ));
                list.Add("localActions", new ConfigOption("localActions", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.LocalActions ));
                list.Add("nodes", new ConfigOption("nodes", new SerializationOptions(JsonMode.Raw), "", this.Nodes ));

                return list;
            }
        }
    }
}