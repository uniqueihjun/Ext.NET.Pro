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
    public partial class DateFilter
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
                
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), null, this.Type ));
                list.Add("beforeText", new ConfigOption("beforeText", null, "Before", this.BeforeText ));
                list.Add("afterText", new ConfigOption("afterText", null, "After", this.AfterText ));
                list.Add("onText", new ConfigOption("onText", null, "On", this.OnText ));
                list.Add("formatProxy", new ConfigOption("formatProxy", new SerializationOptions("dateFormat"), "", this.FormatProxy ));
                list.Add("datePickerOptions", new ConfigOption("datePickerOptions", new SerializationOptions("pickerOpts", JsonMode.Object), null, this.DatePickerOptions ));
                list.Add("valueProxy", new ConfigOption("valueProxy", new SerializationOptions("value", JsonMode.Raw), "", this.ValueProxy ));

                return list;
            }
        }
    }
}