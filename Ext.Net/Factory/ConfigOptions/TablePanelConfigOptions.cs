/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TablePanel
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
                
                list.Add("editorsProxy", new ConfigOption("editorsProxy", new SerializationOptions("editors", JsonMode.Raw), "", this.EditorsProxy ));
                list.Add("editorStrategy", new ConfigOption("editorStrategy", new SerializationOptions(JsonMode.Raw), null, this.EditorStrategy ));
                list.Add("columnLines", new ConfigOption("columnLines", null, false, this.ColumnLines ));
                list.Add("columnModel", new ConfigOption("columnModel", new SerializationOptions("columns", typeof(LazyControlJsonConverter)), null, this.ColumnModel ));
                list.Add("deferRowRender", new ConfigOption("deferRowRender", null, true, this.DeferRowRender ));
                list.Add("disableSelection", new ConfigOption("disableSelection", null, false, this.DisableSelection ));
                list.Add("emptyText", new ConfigOption("emptyText", null, "", this.EmptyText ));
                list.Add("enableColumnHide", new ConfigOption("enableColumnHide", null, true, this.EnableColumnHide ));
                list.Add("enableColumnMove", new ConfigOption("enableColumnMove", null, true, this.EnableColumnMove ));
                list.Add("enableColumnResize", new ConfigOption("enableColumnResize", null, true, this.EnableColumnResize ));
                list.Add("enableLocking", new ConfigOption("enableLocking", null, false, this.EnableLocking ));
                list.Add("forceFit", new ConfigOption("forceFit", null, false, this.ForceFit ));
                list.Add("hideHeaders", new ConfigOption("hideHeaders", null, false, this.HideHeaders ));
                list.Add("multiSelect", new ConfigOption("multiSelect", null, false, this.MultiSelect ));
                list.Add("restrictColumnReorder", new ConfigOption("restrictColumnReorder", null, false, this.RestrictColumnReorder ));
                list.Add("rowLines", new ConfigOption("rowLines", null, true, this.RowLines ));
                list.Add("scroll", new ConfigOption("scroll", new SerializationOptions(JsonMode.ToLower), ScrollMode.Both, this.Scroll ));
                list.Add("scrollDelta", new ConfigOption("scrollDelta", null, 40, this.ScrollDelta ));
                list.Add("simpleSelect", new ConfigOption("simpleSelect", null, false, this.SimpleSelect ));
                list.Add("sortableColumns", new ConfigOption("sortableColumns", null, true, this.SortableColumns ));
                list.Add("selectionModel", new ConfigOption("selectionModel", new SerializationOptions("selModel>Primary"), null, this.SelectionModel ));
                list.Add("selTypeProxy", new ConfigOption("selTypeProxy", new SerializationOptions("selType"), "", this.SelTypeProxy ));
                list.Add("allowDeselect", new ConfigOption("allowDeselect", null, false, this.AllowDeselect ));
                list.Add("invalidateScrollerOnRefresh", new ConfigOption("invalidateScrollerOnRefresh", null, true, this.InvalidateScrollerOnRefresh ));
                list.Add("ignoreTargets", new ConfigOption("ignoreTargets", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.IgnoreTargets ));
                list.Add("storeID", new ConfigOption("storeID", new SerializationOptions("store", JsonMode.ToClientID), "", this.StoreID ));

                return list;
            }
        }
    }
}