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
    public abstract partial class BoxComponentBase
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
                
                list.Add("autoScroll", new ConfigOption("autoScroll", null, false, this.AutoScroll ));
                list.Add("autoHeight", new ConfigOption("autoHeight", null, false, this.AutoHeight ));
                list.Add("autoWidth", new ConfigOption("autoWidth", null, false, this.AutoWidth ));
                list.Add("collapseMode", new ConfigOption("collapseMode", new SerializationOptions(JsonMode.ToLower), CollapseMode.Default, this.CollapseMode ));
                list.Add("boxMaxHeight", new ConfigOption("boxMaxHeight", null, Unit.Empty, this.BoxMaxHeight ));
                list.Add("boxMaxWidth", new ConfigOption("boxMaxWidth", null, Unit.Empty, this.BoxMaxWidth ));
                list.Add("boxMinHeight", new ConfigOption("boxMinHeight", null, Unit.Empty, this.BoxMinHeight ));
                list.Add("boxMinWidth", new ConfigOption("boxMinWidth", null, Unit.Empty, this.BoxMinWidth ));
                list.Add("regionMaxHeight", new ConfigOption("regionMaxHeight", new SerializationOptions("maxHeight"), Unit.Empty, this.RegionMaxHeight ));
                list.Add("regionMaxWidth", new ConfigOption("regionMaxWidth", new SerializationOptions("maxWidth"), Unit.Empty, this.RegionMaxWidth ));
                list.Add("regionMinHeight", new ConfigOption("regionMinHeight", new SerializationOptions("minHeight"), Unit.Empty, this.RegionMinHeight ));
                list.Add("regionMinWidth", new ConfigOption("regionMinWidth", new SerializationOptions("minWidth"), Unit.Empty, this.RegionMinWidth ));
                list.Add("height", new ConfigOption("height", null, Unit.Empty, this.Height ));
                list.Add("margins", new ConfigOption("margins", null, "", this.Margins ));
                list.Add("cMargins", new ConfigOption("cMargins", new SerializationOptions("cmargins"), "", this.CMargins ));
                list.Add("pageX", new ConfigOption("pageX", null, Unit.Empty, this.PageX ));
                list.Add("pageY", new ConfigOption("pageY", null, Unit.Empty, this.PageY ));
                list.Add("region", new ConfigOption("region", new SerializationOptions(JsonMode.ToLower), Region.None, this.Region ));
                list.Add("split", new ConfigOption("split", null, false, this.Split ));
                list.Add("tabTip", new ConfigOption("tabTip", null, "", this.TabTip ));
                list.Add("width", new ConfigOption("width", null, Unit.Empty, this.Width ));
                list.Add("x", new ConfigOption("x", new SerializationOptions(JsonMode.Raw), 0, this.X ));
                list.Add("y", new ConfigOption("y", new SerializationOptions(JsonMode.Raw), 0, this.Y ));
                list.Add("tabMenu", new ConfigOption("tabMenu", new SerializationOptions("tabMenu", typeof(ItemCollectionJsonConverter)), null, this.TabMenu ));
                list.Add("tabMenuHidden", new ConfigOption("tabMenuHidden", null, false, this.TabMenuHidden ));

                return list;
            }
        }
    }
}