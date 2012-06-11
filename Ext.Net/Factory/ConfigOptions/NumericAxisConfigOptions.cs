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
    public partial class NumericAxis
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
                list.Add("constrain", new ConfigOption("constrain", null, true, this.Constrain ));
                list.Add("adjustMaximumByMajorUnit", new ConfigOption("adjustMaximumByMajorUnit", null, false, this.AdjustMaximumByMajorUnit ));
                list.Add("adjustMinimumByMajorUnit", new ConfigOption("adjustMinimumByMajorUnit", null, false, this.AdjustMinimumByMajorUnit ));
                list.Add("roundToDecimal", new ConfigOption("roundToDecimal", null, true, this.RoundToDecimal ));
                list.Add("decimals", new ConfigOption("decimals", null, 2, this.Decimals ));
                list.Add("maximum", new ConfigOption("maximum", null, null, this.Maximum ));
                list.Add("minimum", new ConfigOption("minimum", null, null, this.Minimum ));

                return list;
            }
        }
    }
}