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
    public partial class BarSeries
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
                list.Add("column", new ConfigOption("column", null, false, this.Column ));
                list.Add("stacked", new ConfigOption("stacked", null, false, this.Stacked ));
                list.Add("groupGutter", new ConfigOption("groupGutter", null, 38.2d, this.GroupGutter ));
                list.Add("gutter", new ConfigOption("gutter", null, 38.2d, this.Gutter ));
                list.Add("xPadding", new ConfigOption("xPadding", null, 0, this.XPadding ));
                list.Add("yPadding", new ConfigOption("yPadding", null, 10, this.YPadding ));
                list.Add("style", new ConfigOption("style", new SerializationOptions(JsonMode.Object), null, this.Style ));

                return list;
            }
        }
    }
}