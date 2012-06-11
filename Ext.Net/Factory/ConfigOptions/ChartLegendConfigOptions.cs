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
    public partial class ChartLegend
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
                
                list.Add("boxFill", new ConfigOption("boxFill", null, "", this.BoxFill ));
                list.Add("boxStroke", new ConfigOption("boxStroke", null, "", this.BoxStroke ));
                list.Add("boxStrokeWidth", new ConfigOption("boxStrokeWidth", null, 1, this.BoxStrokeWidth ));
                list.Add("boxZIndex", new ConfigOption("boxZIndex", null, 100, this.BoxZIndex ));
                list.Add("itemSpacing", new ConfigOption("itemSpacing", null, 10, this.ItemSpacing ));
                list.Add("labelColor", new ConfigOption("labelColor", null, "#000", this.LabelColor ));
                list.Add("labelFont", new ConfigOption("labelFont", null, "", this.LabelFont ));
                list.Add("padding", new ConfigOption("padding", null, 5, this.Padding ));
                list.Add("position", new ConfigOption("position", new SerializationOptions(JsonMode.ToLower), LegendPosition.Bottom, this.Position ));
                list.Add("refreshOnItemToggle", new ConfigOption("refreshOnItemToggle", null, false, this.RefreshOnItemToggle ));
                list.Add("update", new ConfigOption("update", null, true, this.Update ));
                list.Add("visible", new ConfigOption("visible", null, true, this.Visible ));
                list.Add("x", new ConfigOption("x", null, 0, this.X ));
                list.Add("y", new ConfigOption("y", null, 0, this.Y ));

                return list;
            }
        }
    }
}