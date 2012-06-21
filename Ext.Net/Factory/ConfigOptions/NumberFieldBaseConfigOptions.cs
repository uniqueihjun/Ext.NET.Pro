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
    public abstract partial class NumberFieldBase
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
                
                list.Add("inputType", new ConfigOption("inputType", new SerializationOptions(JsonMode.ToLower), InputType.Text, this.InputType ));
                list.Add("allowDecimals", new ConfigOption("allowDecimals", null, true, this.AllowDecimals ));
                list.Add("autoStripChars", new ConfigOption("autoStripChars", null, false, this.AutoStripChars ));
                list.Add("baseChars", new ConfigOption("baseChars", null, "0123456789", this.BaseChars ));
                list.Add("decimalPrecision", new ConfigOption("decimalPrecision", null, 2, this.DecimalPrecision ));
                list.Add("decimalSeparatorProxy", new ConfigOption("decimalSeparatorProxy", new SerializationOptions("decimalSeparator"), "", this.DecimalSeparatorProxy ));
                list.Add("maxText", new ConfigOption("maxText", null, "The maximum value for this field is {0}", this.MaxText ));
                list.Add("maxValue", new ConfigOption("maxValue", null, Double.MaxValue, this.MaxValue ));
                list.Add("minText", new ConfigOption("minText", null, "The minimum value for this field is {0}", this.MinText ));
                list.Add("minValue", new ConfigOption("minValue", null, Double.MinValue, this.MinValue ));
                list.Add("nanText", new ConfigOption("nanText", null, "{0} is not a valid number", this.NanText ));
                list.Add("negativeText", new ConfigOption("negativeText", null, "", this.NegativeText ));
                list.Add("step", new ConfigOption("step", null, 1.0, this.Step ));
                list.Add("trimTrailedZeros", new ConfigOption("trimTrailedZeros", null, true, this.TrimTrailedZeros ));
                list.Add("submitLocaleSeparator", new ConfigOption("submitLocaleSeparator", null, true, this.SubmitLocaleSeparator ));

                return list;
            }
        }
    }
}