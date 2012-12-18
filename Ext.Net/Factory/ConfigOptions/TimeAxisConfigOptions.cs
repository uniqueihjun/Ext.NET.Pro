/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class TimeAxis
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
                list.Add("roundToDecimal", new ConfigOption("roundToDecimal", null, false, this.RoundToDecimal ));
                list.Add("constrain", new ConfigOption("constrain", null, false, this.Constrain ));
                list.Add("dateFormatProxy", new ConfigOption("dateFormatProxy", new SerializationOptions("dateFormat"), "", this.DateFormatProxy ));
                list.Add("fromDate", new ConfigOption("fromDate", new SerializationOptions(typeof(CtorDateTimeJsonConverter)), new DateTime(0001, 01, 01), this.FromDate ));
                list.Add("toDate", new ConfigOption("toDate", new SerializationOptions(typeof(CtorDateTimeJsonConverter)), new DateTime(9999, 12, 31), this.ToDate ));
                list.Add("stepProxy", new ConfigOption("stepProxy", new SerializationOptions("step", JsonMode.AlwaysArray), "", this.StepProxy ));

                return list;
            }
        }
    }
}