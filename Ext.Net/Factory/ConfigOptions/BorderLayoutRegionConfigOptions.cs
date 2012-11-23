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
    public partial class BorderLayoutRegion
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
                
                list.Add("region", new ConfigOption("region", new SerializationOptions(JsonMode.ToLower), null, this.Region ));
                list.Add("animFloat", new ConfigOption("animFloat", null, true, this.AnimFloat ));
                list.Add("autoHide", new ConfigOption("autoHide", null, true, this.AutoHide ));
                list.Add("cMarginsSummary", new ConfigOption("cMarginsSummary", new SerializationOptions("cmargins"), "", this.CMarginsSummary ));
                list.Add("cMargins", new ConfigOption("cMargins", new SerializationOptions("cmargins", typeof(MarginsJsonConverter)), new Margins(-1, -1, -1, -1), this.CMargins ));
                list.Add("collapseMode", new ConfigOption("collapseMode", new SerializationOptions(JsonMode.ToLower), CollapseMode.Default, this.CollapseMode ));
                list.Add("collapsible", new ConfigOption("collapsible", null, false, this.Collapsible ));
                list.Add("floatable", new ConfigOption("floatable", null, true, this.Floatable ));
                list.Add("marginsSummary", new ConfigOption("marginsSummary", new SerializationOptions("margins"), "", this.MarginsSummary ));
                list.Add("margins", new ConfigOption("margins", new SerializationOptions("margins", typeof(MarginsJsonConverter)), new Margins(-1, -1, -1, -1), this.Margins ));
                list.Add("minHeight", new ConfigOption("minHeight", null, Unit.Pixel(50), this.MinHeight ));
                list.Add("maxHeight", new ConfigOption("maxHeight", null, Unit.Empty, this.MaxHeight ));
                list.Add("maxWidth", new ConfigOption("maxWidth", null, Unit.Empty, this.MaxWidth ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(50), this.MinWidth ));
                list.Add("useSplitTips", new ConfigOption("useSplitTips", null, false, this.UseSplitTips ));
                list.Add("collapsibleSplitTip", new ConfigOption("collapsibleSplitTip", null, "Drag to resize. Double click to hide.", this.CollapsibleSplitTip ));
                list.Add("expandableSplitTip", new ConfigOption("expandableSplitTip", null, "Double click to show.", this.ExpandableSplitTip ));
                list.Add("split", new ConfigOption("split", null, false, this.Split ));
                list.Add("splitTip", new ConfigOption("splitTip", null, "Drag to resize.", this.SplitTip ));

                return list;
            }
        }
    }
}