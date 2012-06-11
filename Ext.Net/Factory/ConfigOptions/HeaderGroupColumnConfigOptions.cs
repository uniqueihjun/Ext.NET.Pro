/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class HeaderGroupColumn
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
                
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), Alignment.Left, this.Align ));
                list.Add("colSpan", new ConfigOption("colSpan", new SerializationOptions("colspan"), 1, this.ColSpan ));
                list.Add("groupId", new ConfigOption("groupId", new SerializationOptions("dataIndex"), "", this.GroupId ));
                list.Add("tooltip", new ConfigOption("tooltip", null, "", this.Tooltip ));
                list.Add("header", new ConfigOption("header", null, "", this.Header ));

                return list;
            }
        }
    }
}