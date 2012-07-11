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
    public abstract partial class MonthViewBase
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
                
                list.Add("showHeader", new ConfigOption("showHeader", null, false, this.ShowHeader ));
                list.Add("showTime", new ConfigOption("showTime", null, true, this.ShowTime ));
                list.Add("showTodayText", new ConfigOption("showTodayText", null, true, this.ShowTodayText ));
                list.Add("showWeekLinks", new ConfigOption("showWeekLinks", null, false, this.ShowWeekLinks ));
                list.Add("showWeekNumbers", new ConfigOption("showWeekNumbers", null, false, this.ShowWeekNumbers ));
                list.Add("weekLinkOverClass", new ConfigOption("weekLinkOverClass", null, "ext-week-link-over", this.WeekLinkOverClass ));

                return list;
            }
        }
    }
}