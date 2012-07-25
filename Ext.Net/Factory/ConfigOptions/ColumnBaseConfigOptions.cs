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
    public abstract partial class ColumnBase
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
                
                list.Add("headerItems", new ConfigOption("headerItems", new SerializationOptions("headerItems", typeof(ItemCollectionJsonConverter)), null, this.HeaderItems ));
                list.Add("hideTitleEl", new ConfigOption("hideTitleEl", null, false, this.HideTitleEl ));
                list.Add("locked", new ConfigOption("locked", null, null, this.Locked ));
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), Alignment.Left, this.Align ));
                list.Add("columns", new ConfigOption("columns", new SerializationOptions("columns", typeof(ItemCollectionJsonConverter)), null, this.Columns ));
                list.Add("dataIndex", new ConfigOption("dataIndex", null, null, this.DataIndex ));
                list.Add("draggableProxy", new ConfigOption("draggableProxy", new SerializationOptions("draggable"), true, this.DraggableProxy ));
                list.Add("editorRenderer", new ConfigOption("editorRenderer", new SerializationOptions(typeof(RendererJsonConverter)), null, this.EditorRenderer ));
                list.Add("editorProxy", new ConfigOption("editorProxy", new SerializationOptions("editor", JsonMode.Raw), "", this.EditorProxy ));
                list.Add("editorsProxy", new ConfigOption("editorsProxy", new SerializationOptions("editors", JsonMode.Raw), "", this.EditorsProxy ));
                list.Add("editorStrategy", new ConfigOption("editorStrategy", new SerializationOptions(JsonMode.Raw), null, this.EditorStrategy ));
                list.Add("emptyCellText", new ConfigOption("emptyCellText", null, "", this.EmptyCellText ));
                list.Add("groupable", new ConfigOption("groupable", null, true, this.Groupable ));
                list.Add("hideable", new ConfigOption("hideable", null, true, this.Hideable ));
                list.Add("menuDisabled", new ConfigOption("menuDisabled", null, false, this.MenuDisabled ));
                list.Add("menuText", new ConfigOption("menuText", null, "", this.MenuText ));
                list.Add("renderer", new ConfigOption("renderer", new SerializationOptions(typeof(RendererJsonConverter)), null, this.Renderer ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("resizableProxy", new ConfigOption("resizableProxy", new SerializationOptions("resizable"), true, this.ResizableProxy ));
                list.Add("sealed", new ConfigOption("sealed", null, false, this.Sealed ));
                list.Add("sortable", new ConfigOption("sortable", null, null, this.Sortable ));
                list.Add("tdCls", new ConfigOption("tdCls", null, "", this.TdCls ));
                list.Add("stopSelectionSelectors", new ConfigOption("stopSelectionSelectors", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.StopSelectionSelectors ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));

                return list;
            }
        }
    }
}