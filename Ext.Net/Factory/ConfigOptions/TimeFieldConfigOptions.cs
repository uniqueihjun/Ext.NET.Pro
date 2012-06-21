/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class TimeField
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
                
                list.Add("valueProxy", new ConfigOption("valueProxy", new SerializationOptions("value"), null, this.ValueProxy ));
                list.Add("altFormatsProxy", new ConfigOption("altFormatsProxy", new SerializationOptions("altFormats"), "", this.AltFormatsProxy ));
                list.Add("formatProxy", new ConfigOption("formatProxy", new SerializationOptions("format"), "", this.FormatProxy ));
                list.Add("increment", new ConfigOption("increment", null, 15, this.Increment ));
                list.Add("invalidText", new ConfigOption("invalidText", null, "{0} is not a valid time", this.InvalidText ));
                list.Add("maxText", new ConfigOption("maxText", null, "The time in this field must be equal to or before {0}", this.MaxText ));
                list.Add("maxTimeProxy", new ConfigOption("maxTimeProxy", new SerializationOptions("maxValue"), "", this.MaxTimeProxy ));
                list.Add("minTimeProxy", new ConfigOption("minTimeProxy", new SerializationOptions("minValue"), "", this.MinTimeProxy ));
                list.Add("minText", new ConfigOption("minText", null, "The time in this field must be equal to or after {0}", this.MinText ));
                list.Add("pickerMaxHeight", new ConfigOption("pickerMaxHeight", null, 300, this.PickerMaxHeight ));
                list.Add("selectOnTab", new ConfigOption("selectOnTab", null, true, this.SelectOnTab ));
                list.Add("snapToIncrement", new ConfigOption("snapToIncrement", null, false, this.SnapToIncrement ));
                list.Add("submitFormatProxy", new ConfigOption("submitFormatProxy", new SerializationOptions("submitFormat"), "", this.SubmitFormatProxy ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}