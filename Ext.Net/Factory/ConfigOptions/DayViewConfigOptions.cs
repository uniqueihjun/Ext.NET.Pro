/********
 * @version   : 1.6.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
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
    public partial class DayView
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
                
                list.Add("dayCount", new ConfigOption("dayCount", null, 1, this.DayCount ));
                list.Add("dDCreateEventText", new ConfigOption("dDCreateEventText", new SerializationOptions("ddCreateEventText"), "Create event for {0}", this.DDCreateEventText ));
                list.Add("dDMoveEventText", new ConfigOption("dDMoveEventText", new SerializationOptions("ddMoveEventText"), "Move event to {0}", this.DDMoveEventText ));
                list.Add("dDResizeEventText", new ConfigOption("dDResizeEventText", new SerializationOptions("ddResizeEventText"), "Update event to {0}", this.DDResizeEventText ));
                list.Add("showTime", new ConfigOption("showTime", null, true, this.ShowTime ));
                list.Add("showTodayText", new ConfigOption("showTodayText", null, true, this.ShowTodayText ));
                list.Add("todayText", new ConfigOption("todayText", null, "Today", this.TodayText ));

                return list;
            }
        }
    }
}