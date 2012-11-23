/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class SeriesLabel
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
                
                list.Add("display", new ConfigOption("display", new SerializationOptions(JsonMode.ToCamelLower), SeriesLabelDisplay.None, this.Display ));
                list.Add("color", new ConfigOption("color", null, "", this.Color ));
                list.Add("contrast", new ConfigOption("contrast", null, false, this.Contrast ));
                list.Add("field", new ConfigOption("field", new SerializationOptions(typeof(SingleStringArrayJsonConverter)), null, this.Field ));
                list.Add("minMargin", new ConfigOption("minMargin", null, 50, this.MinMargin ));
                list.Add("orientation", new ConfigOption("orientation", new SerializationOptions(JsonMode.ToLower), Orientation.Horizontal, this.Orientation ));
                list.Add("renderer", new ConfigOption("renderer", new SerializationOptions(JsonMode.Raw), null, this.Renderer ));

                return list;
            }
        }
    }
}