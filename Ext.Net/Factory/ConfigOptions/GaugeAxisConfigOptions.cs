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
    public partial class GaugeAxis
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
                list.Add("position", new ConfigOption("position", null, null, this.Position ));
                list.Add("margin", new ConfigOption("margin", null, 10, this.Margin ));
                list.Add("maximum", new ConfigOption("maximum", null, null, this.Maximum ));
                list.Add("minimum", new ConfigOption("minimum", null, null, this.Minimum ));
                list.Add("steps", new ConfigOption("steps", null, null, this.Steps ));
                list.Add("title", new ConfigOption("title", null, null, this.Title ));

                return list;
            }
        }
    }
}