/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class CalendarViewDirectEvents
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
                
                list.Add("dateChange", new ConfigOption("dateChange", new SerializationOptions("datechange", typeof(DirectEventJsonConverter)), null, this.DateChange ));
                list.Add("dayOut", new ConfigOption("dayOut", new SerializationOptions("dayout", typeof(DirectEventJsonConverter)), null, this.DayOut ));
                list.Add("dayOver", new ConfigOption("dayOver", new SerializationOptions("dayover", typeof(DirectEventJsonConverter)), null, this.DayOver ));
                list.Add("eventClick", new ConfigOption("eventClick", new SerializationOptions("eventclick", typeof(DirectEventJsonConverter)), null, this.EventClick ));
                list.Add("eventMove", new ConfigOption("eventMove", new SerializationOptions("eventmove", typeof(DirectEventJsonConverter)), null, this.EventMove ));
                list.Add("eventOut", new ConfigOption("eventOut", new SerializationOptions("eventout", typeof(DirectEventJsonConverter)), null, this.EventOut ));
                list.Add("eventOver", new ConfigOption("eventOver", new SerializationOptions("eventover", typeof(DirectEventJsonConverter)), null, this.EventOver ));
                list.Add("eventsRendered", new ConfigOption("eventsRendered", new SerializationOptions("eventsrendered", typeof(DirectEventJsonConverter)), null, this.EventsRendered ));
                list.Add("initDrag", new ConfigOption("initDrag", new SerializationOptions("initdrag", typeof(DirectEventJsonConverter)), null, this.InitDrag ));
                list.Add("rangeSelect", new ConfigOption("rangeSelect", new SerializationOptions("rangeselect", typeof(DirectEventJsonConverter)), null, this.RangeSelect ));

                return list;
            }
        }
    }
}