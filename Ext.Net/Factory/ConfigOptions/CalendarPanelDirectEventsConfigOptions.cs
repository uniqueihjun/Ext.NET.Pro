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
    public partial class CalendarPanelDirectEvents
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
                list.Add("dayClick", new ConfigOption("dayClick", new SerializationOptions("dayclick", typeof(DirectEventJsonConverter)), null, this.DayClick ));
                list.Add("eventAdd", new ConfigOption("eventAdd", new SerializationOptions("eventadd", typeof(DirectEventJsonConverter)), null, this.EventAdd ));
                list.Add("eventCancel", new ConfigOption("eventCancel", new SerializationOptions("eventcancel", typeof(DirectEventJsonConverter)), null, this.EventCancel ));
                list.Add("eventClick", new ConfigOption("eventClick", new SerializationOptions("eventclick", typeof(DirectEventJsonConverter)), null, this.EventClick ));
                list.Add("eventDelete", new ConfigOption("eventDelete", new SerializationOptions("eventdelete", typeof(DirectEventJsonConverter)), null, this.EventDelete ));
                list.Add("eventMove", new ConfigOption("eventMove", new SerializationOptions("eventmove", typeof(DirectEventJsonConverter)), null, this.EventMove ));
                list.Add("eventOut", new ConfigOption("eventOut", new SerializationOptions("eventout", typeof(DirectEventJsonConverter)), null, this.EventOut ));
                list.Add("eventOver", new ConfigOption("eventOver", new SerializationOptions("eventover", typeof(DirectEventJsonConverter)), null, this.EventOver ));
                list.Add("eventResize", new ConfigOption("eventResize", new SerializationOptions("eventresize", typeof(DirectEventJsonConverter)), null, this.EventResize ));
                list.Add("eventsRendered", new ConfigOption("eventsRendered", new SerializationOptions("eventsrendered", typeof(DirectEventJsonConverter)), null, this.EventsRendered ));
                list.Add("eventUpdate", new ConfigOption("eventUpdate", new SerializationOptions("eventupdate", typeof(DirectEventJsonConverter)), null, this.EventUpdate ));
                list.Add("initDrag", new ConfigOption("initDrag", new SerializationOptions("initdrag", typeof(DirectEventJsonConverter)), null, this.InitDrag ));
                list.Add("rangeSelect", new ConfigOption("rangeSelect", new SerializationOptions("rangeselect", typeof(DirectEventJsonConverter)), null, this.RangeSelect ));
                list.Add("viewChange", new ConfigOption("viewChange", new SerializationOptions("viewchange", typeof(DirectEventJsonConverter)), null, this.ViewChange ));

                return list;
            }
        }
    }
}