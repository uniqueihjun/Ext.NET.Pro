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
    public partial class LineSeries
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
                list.Add("fill", new ConfigOption("fill", null, false, this.Fill ));
                list.Add("showMarkers", new ConfigOption("showMarkers", null, true, this.ShowMarkers ));
                list.Add("markerConfig", new ConfigOption("markerConfig", new SerializationOptions("markerConfig", JsonMode.Object), null, this.MarkerConfig ));
                list.Add("selectionTolerance", new ConfigOption("selectionTolerance", null, 20, this.SelectionTolerance ));
                list.Add("smooth", new ConfigOption("smooth", null, 0, this.Smooth ));
                list.Add("style", new ConfigOption("style", new SerializationOptions(JsonMode.Object), null, this.Style ));

                return list;
            }
        }
    }
}