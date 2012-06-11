/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public abstract partial class SliderBase
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
                
                list.Add("animate", new ConfigOption("animate", null, true, this.Animate ));
                list.Add("clickToChange", new ConfigOption("clickToChange", null, true, this.ClickToChange ));
                list.Add("constrainThumbs", new ConfigOption("constrainThumbs", null, true, this.ConstrainThumbs ));
                list.Add("decimalPrecision", new ConfigOption("decimalPrecision", null, 0, this.DecimalPrecision ));
                list.Add("increment", new ConfigOption("increment", null, 0, this.Increment ));
                list.Add("keyIncrement", new ConfigOption("keyIncrement", null, 1, this.KeyIncrement ));
                list.Add("maxValue", new ConfigOption("maxValue", null, 100d, this.MaxValue ));
                list.Add("minValue", new ConfigOption("minValue", null, 0d, this.MinValue ));
                list.Add("vertical", new ConfigOption("vertical", null, false, this.Vertical ));
                list.Add("zeroBasedSnapping", new ConfigOption("zeroBasedSnapping", null, false, this.ZeroBasedSnapping ));
                list.Add("useTips", new ConfigOption("useTips", null, true, this.UseTips ));
                list.Add("tipText", new ConfigOption("tipText", new SerializationOptions(JsonMode.Raw), null, this.TipText ));
                list.Add("valueProxy", new ConfigOption("valueProxy", new SerializationOptions("values", JsonMode.Serialize), null, this.ValueProxy ));

                return list;
            }
        }
    }
}