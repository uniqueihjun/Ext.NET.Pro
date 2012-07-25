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
    public partial class UpdateOptions
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
                
                list.Add("url", new ConfigOption("url", null, "", this.Url ));
                list.Add("method", new ConfigOption("method", null, HttpMethod.Default, this.Method ));
                list.Add("params", new ConfigOption("params", null, "", this.Params ));
                list.Add("scripts", new ConfigOption("scripts", null, false, this.Scripts ));
                list.Add("callback", new ConfigOption("callback", new SerializationOptions(JsonMode.Raw), "", this.Callback ));
                list.Add("discardUrl", new ConfigOption("discardUrl", null, true, this.DiscardUrl ));
                list.Add("timeout", new ConfigOption("timeout", null, 30, this.Timeout ));
                list.Add("nocache", new ConfigOption("nocache", null, false, this.Nocache ));
                list.Add("text", new ConfigOption("text", null, "Loading...", this.Text ));

                return list;
            }
        }
    }
}