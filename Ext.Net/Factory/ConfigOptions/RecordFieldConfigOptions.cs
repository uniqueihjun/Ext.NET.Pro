/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class RecordField
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
                
                list.Add("allowBlank", new ConfigOption("allowBlank", null, true, this.AllowBlank ));
                list.Add("nameProxy", new ConfigOption("nameProxy", new SerializationOptions("name"), null, this.NameProxy ));
                list.Add("mapping", new ConfigOption("mapping", null, "", this.Mapping ));
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), RecordFieldType.Auto, this.Type ));
                list.Add("sortType", new ConfigOption("sortType", new SerializationOptions(typeof(ToLowerCamelCase)), SortTypeMethod.None, this.SortType ));
                list.Add("sortDir", new ConfigOption("sortDir", null, SortDirection.Default, this.SortDir ));
                list.Add("submitEmptyValue", new ConfigOption("submitEmptyValue", new SerializationOptions(JsonMode.ToLower), EmptyValue.Undefined, this.SubmitEmptyValue ));
                list.Add("customSortType", new ConfigOption("customSortType", new SerializationOptions("sortType", JsonMode.Raw), null, this.CustomSortType ));
                list.Add("convert", new ConfigOption("convert", new SerializationOptions(JsonMode.Raw), null, this.Convert ));
                list.Add("dateFormat", new ConfigOption("dateFormat", new SerializationOptions(typeof(NetToPHPDateFormatStringJsonConverter)), "", this.DateFormat ));
                list.Add("defaultValue", new ConfigOption("defaultValue", new SerializationOptions(JsonMode.Raw), "", this.DefaultValue ));
                list.Add("useNull", new ConfigOption("useNull", null, false, this.UseNull ));

                return list;
            }
        }
    }
}