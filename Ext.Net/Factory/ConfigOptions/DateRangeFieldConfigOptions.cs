/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class DateRangeField
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
                
                list.Add("toText", new ConfigOption("toText", null, "to", this.ToText ));
                list.Add("allDayText", new ConfigOption("allDayText", null, "All day", this.AllDayText ));
                list.Add("singleLine", new ConfigOption("singleLine", null, null, this.SingleLine ));
                list.Add("singleLineMinWidth", new ConfigOption("singleLineMinWidth", null, 490, this.SingleLineMinWidth ));
                list.Add("dateFormatProxy", new ConfigOption("dateFormatProxy", new SerializationOptions("dateFormat"), "", this.DateFormatProxy ));
                list.Add("timeFormattProxy", new ConfigOption("timeFormattProxy", new SerializationOptions("timeFormat"), "", this.TimeFormattProxy ));

                return list;
            }
        }
    }
}