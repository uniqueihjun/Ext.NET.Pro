/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class TreeGridColumn
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
                
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), TextAlign.Left, this.Align ));
                list.Add("cls", new ConfigOption("cls", null, null, this.Cls ));
                list.Add("dataIndex", new ConfigOption("dataIndex", null, null, this.DataIndex ));
                list.Add("header", new ConfigOption("header", null, "", this.Header ));
                list.Add("hideable", new ConfigOption("hideable", null, true, this.Hideable ));
                list.Add("template", new ConfigOption("template", new SerializationOptions("tpl"), "", this.Template ));
                list.Add("xTemplate", new ConfigOption("xTemplate", new SerializationOptions("tpl", typeof(LazyControlJsonConverter)), null, this.XTemplate ));
                list.Add("width", new ConfigOption("width", null, 0.0, this.Width ));
                list.Add("sortType", new ConfigOption("sortType", new SerializationOptions(typeof(ToLowerCamelCase)), SortTypeMethod.None, this.SortType ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));

                return list;
            }
        }
    }
}