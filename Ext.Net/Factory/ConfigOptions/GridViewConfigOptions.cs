/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class GridView
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
                
                list.Add("autoFill", new ConfigOption("autoFill", null, false, this.AutoFill ));
                list.Add("columnsText", new ConfigOption("columnsText", null, "", this.ColumnsText ));
                list.Add("cellSelector", new ConfigOption("cellSelector", null, "", this.CellSelector ));
                list.Add("cellSelectorDepth", new ConfigOption("cellSelectorDepth", null, 4, this.CellSelectorDepth ));
                list.Add("deferEmptyText", new ConfigOption("deferEmptyText", null, true, this.DeferEmptyText ));
                list.Add("emptyText", new ConfigOption("emptyText", null, "", this.EmptyText ));
                list.Add("enableRowBody", new ConfigOption("enableRowBody", null, false, this.EnableRowBody ));
                list.Add("forceFit", new ConfigOption("forceFit", null, false, this.ForceFit ));
                list.Add("headersDisabled", new ConfigOption("headersDisabled", null, false, this.HeadersDisabled ));
                list.Add("headerMenuOpenCls", new ConfigOption("headerMenuOpenCls", null, "x-grid3-hd-menu-open", this.HeaderMenuOpenCls ));
                list.Add("rowOverCls", new ConfigOption("rowOverCls", null, "x-grid3-row-over", this.RowOverCls ));
                list.Add("rowSelector", new ConfigOption("rowSelector", null, "", this.RowSelector ));
                list.Add("rowSelectorDepth", new ConfigOption("rowSelectorDepth", null, 10, this.RowSelectorDepth ));
                list.Add("rowBodySelector", new ConfigOption("rowBodySelector", null, "div.x-grid3-row-body", this.RowBodySelector ));
                list.Add("rowBodySelectorDepth", new ConfigOption("rowBodySelectorDepth", null, 10, this.RowBodySelectorDepth ));
                list.Add("scrollOffset", new ConfigOption("scrollOffset", null, 19, this.ScrollOffset ));
                list.Add("sortAscText", new ConfigOption("sortAscText", null, "", this.SortAscText ));
                list.Add("sortDescText", new ConfigOption("sortDescText", null, "", this.SortDescText ));
                list.Add("selectedRowClass", new ConfigOption("selectedRowClass", null, "x-grid3-row-selected", this.SelectedRowClass ));
                list.Add("sortClasses", new ConfigOption("sortClasses", new SerializationOptions(JsonMode.Raw), "", this.SortClasses ));
                list.Add("markDirty", new ConfigOption("markDirty", null, true, this.MarkDirty ));
                list.Add("getRowClass", new ConfigOption("getRowClass", new SerializationOptions(JsonMode.Raw), null, this.GetRowClass ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));
                list.Add("standardHeaderRow", new ConfigOption("standardHeaderRow", null, true, this.StandardHeaderRow ));
                list.Add("splitHandleWidth", new ConfigOption("splitHandleWidth", null, 5, this.SplitHandleWidth ));
                list.Add("headerGroupRowsProxy", new ConfigOption("headerGroupRowsProxy", new SerializationOptions("headerGroupRows", JsonMode.Raw), "", this.headerGroupRowsProxy ));
                list.Add("headerRowsProxy", new ConfigOption("headerRowsProxy", new SerializationOptions("headerRows", JsonMode.Raw), "", this.HeaderRowsProxy ));
                list.Add("templates", new ConfigOption("templates", new SerializationOptions("templates", JsonMode.Object), null, this.Templates ));

                return list;
            }
        }
    }
}