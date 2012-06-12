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
                
                list.Add("values", new ConfigOption("values", new SerializationOptions("values", typeof(IntArrayJsonConverter)), null, this.Values ));
                list.Add("valueProxy", new ConfigOption("valueProxy", new SerializationOptions("value", JsonMode.Raw), int.MinValue, this.ValueProxy ));
                list.Add("animate", new ConfigOption("animate", null, true, this.Animate ));
                list.Add("clickToChange", new ConfigOption("clickToChange", null, true, this.ClickToChange ));
                list.Add("constrainThumbs", new ConfigOption("constrainThumbs", null, true, this.ConstrainThumbs ));
                list.Add("decimalPrecision", new ConfigOption("decimalPrecision", null, 0, this.DecimalPrecision ));
                list.Add("increment", new ConfigOption("increment", null, 0, this.Increment ));
                list.Add("keyIncrement", new ConfigOption("keyIncrement", null, 1, this.KeyIncrement ));
                list.Add("maxValue", new ConfigOption("maxValue", null, 100, this.MaxValue ));
                list.Add("minValue", new ConfigOption("minValue", null, 0, this.MinValue ));
                list.Add("vertical", new ConfigOption("vertical", null, false, this.Vertical ));
                list.Add("topThumbZIndex", new ConfigOption("topThumbZIndex", null, 10000, this.TopThumbZIndex ));

                return list;
            }
        }
    }
}