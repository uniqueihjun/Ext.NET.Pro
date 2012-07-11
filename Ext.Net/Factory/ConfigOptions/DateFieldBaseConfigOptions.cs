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
    public abstract partial class DateFieldBase
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
                
                list.Add("valueProxy", new ConfigOption("valueProxy", new SerializationOptions("value", typeof(CtorDateTimeJsonConverter)), null, this.ValueProxy ));
                list.Add("altFormatsProxy", new ConfigOption("altFormatsProxy", new SerializationOptions("altFormats"), "", this.AltFormatsProxy ));
                list.Add("disabledDatesProxy", new ConfigOption("disabledDatesProxy", new SerializationOptions("disabledDates", JsonMode.Raw), "", this.DisabledDatesProxy ));
                list.Add("disabledDatesText", new ConfigOption("disabledDatesText", null, "", this.DisabledDatesText ));
                list.Add("disabledDays", new ConfigOption("disabledDays", new SerializationOptions(typeof(IntArrayJsonConverter)), null, this.DisabledDays ));
                list.Add("disabledDaysText", new ConfigOption("disabledDaysText", null, "", this.DisabledDaysText ));
                list.Add("formatProxy", new ConfigOption("formatProxy", new SerializationOptions("format"), "", this.FormatProxy ));
                list.Add("invalidText", new ConfigOption("invalidText", null, "", this.InvalidText ));
                list.Add("maxText", new ConfigOption("maxText", null, "", this.MaxText ));
                list.Add("maxDate", new ConfigOption("maxDate", new SerializationOptions("maxValue", typeof(CtorDateTimeJsonConverter)), new DateTime(9999, 12, 31), this.MaxDate ));
                list.Add("minText", new ConfigOption("minText", null, "", this.MinText ));
                list.Add("minDate", new ConfigOption("minDate", new SerializationOptions("minValue", typeof(CtorDateTimeJsonConverter)), new DateTime(0001, 01, 01), this.MinDate ));
                list.Add("showToday", new ConfigOption("showToday", null, true, this.ShowToday ));
                list.Add("startDay", new ConfigOption("startDay", null, -1, this.StartDay ));
                list.Add("submitFormatProxy", new ConfigOption("submitFormatProxy", new SerializationOptions("submitFormat"), "", this.SubmitFormatProxy ));
                list.Add("useStrict", new ConfigOption("useStrict", null, false, this.UseStrict ));
                list.Add("okText", new ConfigOption("okText", null, "", this.OkText ));
                list.Add("cancelText", new ConfigOption("cancelText", null, "", this.CancelText ));
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), DatePickerType.Date, this.Type ));

                return list;
            }
        }
    }
}