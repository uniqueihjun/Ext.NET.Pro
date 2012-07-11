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
    public abstract partial class AbstractSeries
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
                
                list.Add("seriesID", new ConfigOption("seriesID", new SerializationOptions("seriesId"), "", this.SeriesID ));
                list.Add("highlight", new ConfigOption("highlight", null, false, this.Highlight ));
                list.Add("highlightConfig", new ConfigOption("highlightConfig", new SerializationOptions("highlightCfg", JsonMode.Object), null, this.HighlightConfig ));
                list.Add("label", new ConfigOption("label", new SerializationOptions(JsonMode.Object), null, this.Label ));
                list.Add("renderer", new ConfigOption("renderer", new SerializationOptions(JsonMode.Raw), null, this.Renderer ));
                list.Add("showInLegend", new ConfigOption("showInLegend", null, true, this.ShowInLegend ));
                list.Add("tips", new ConfigOption("tips", new SerializationOptions("tips", typeof(LazyControlJsonConverter)), null, this.Tips ));
                list.Add("title", new ConfigOption("title", null, "", this.Title ));
                list.Add("titles", new ConfigOption("titles", new SerializationOptions("title", typeof(SingleStringArrayJsonConverter)), null, this.Titles ));
                list.Add("xField", new ConfigOption("xField", new SerializationOptions(typeof(SingleStringArrayJsonConverter)), null, this.XField ));
                list.Add("yField", new ConfigOption("yField", new SerializationOptions(typeof(SingleStringArrayJsonConverter)), null, this.YField ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));

                return list;
            }
        }
    }
}