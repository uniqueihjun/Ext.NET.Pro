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
    public partial class CheckboxSelectionModel
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
                
                list.Add("checkOnly", new ConfigOption("checkOnly", null, false, this.CheckOnly ));
                list.Add("header", new ConfigOption("header", null, "<div class=\"x-grid3-hd-checker\"> </div>", this.Header ));
                list.Add("sortable", new ConfigOption("sortable", null, false, this.Sortable ));
                list.Add("allowDeselect", new ConfigOption("allowDeselect", null, true, this.AllowDeselect ));
                list.Add("width", new ConfigOption("width", null, 20, this.Width ));
                list.Add("rowSpan", new ConfigOption("rowSpan", null, 1, this.RowSpan ));
                list.Add("keepSelectionOnClick", new ConfigOption("keepSelectionOnClick", new SerializationOptions(JsonMode.ToLower), KeepSelectionMode.Always, this.KeepSelectionOnClick ));

                return list;
            }
        }
    }
}