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
    public abstract partial class AbstractWriter
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
                list.Add("nameProperty", new ConfigOption("nameProperty", null, "", this.NameProperty ));
                list.Add("writeAllFields", new ConfigOption("writeAllFields", null, true, this.WriteAllFields ));
                list.Add("getRecordData", new ConfigOption("getRecordData", new SerializationOptions(JsonMode.Raw), null, this.GetRecordData ));
                list.Add("filterRecord", new ConfigOption("filterRecord", new SerializationOptions(JsonMode.Raw), null, this.FilterRecord ));
                list.Add("filterField", new ConfigOption("filterField", new SerializationOptions(JsonMode.Raw), null, this.FilterField ));
                list.Add("prepare", new ConfigOption("prepare", new SerializationOptions(JsonMode.Raw), null, this.Prepare ));
                list.Add("htmlEncode", new ConfigOption("htmlEncode", null, false, this.HtmlEncode ));
                list.Add("dateFormat", new ConfigOption("dateFormat", new SerializationOptions(typeof(NetToPHPDateFormatStringJsonConverter)), "", this.DateFormat ));

                return list;
            }
        }
    }
}