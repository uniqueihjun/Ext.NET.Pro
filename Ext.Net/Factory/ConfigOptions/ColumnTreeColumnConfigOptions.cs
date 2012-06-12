/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class ColumnTreeColumn
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
                
                list.Add("dataIndex", new ConfigOption("dataIndex", null, null, this.DataIndex ));
                list.Add("header", new ConfigOption("header", null, "", this.Header ));
                list.Add("cls", new ConfigOption("cls", null, "", this.Cls ));
                list.Add("width", new ConfigOption("width", null, 0, this.Width ));
                list.Add("renderer", new ConfigOption("renderer", new SerializationOptions(typeof(RendererJsonConverter)), null, this.Renderer ));

                return list;
            }
        }
    }
}