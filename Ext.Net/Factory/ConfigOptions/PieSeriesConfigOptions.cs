/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class PieSeries
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
                
                list.Add("type", new ConfigOption("type", null, null, this.Type ));
                list.Add("angleField", new ConfigOption("angleField", null, "", this.AngleField ));
                list.Add("colorSet", new ConfigOption("colorSet", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.ColorSet ));
                list.Add("donut", new ConfigOption("donut", null, 0, this.Donut ));
                list.Add("highlightDuration", new ConfigOption("highlightDuration", null, 150, this.HighlightDuration ));
                list.Add("highlightSegmentMarginProxy", new ConfigOption("highlightSegmentMarginProxy", new SerializationOptions("highlightCfg", JsonMode.Raw), "", this.HighlightSegmentMarginProxy ));
                list.Add("lengthField", new ConfigOption("lengthField", null, "", this.LengthField ));
                list.Add("showInLegend", new ConfigOption("showInLegend", null, false, this.ShowInLegend ));
                list.Add("style", new ConfigOption("style", new SerializationOptions(JsonMode.Object), null, this.Style ));

                return list;
            }
        }
    }
}