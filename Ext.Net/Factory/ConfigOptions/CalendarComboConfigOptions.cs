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
    public partial class CalendarCombo
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
                
                list.Add("calendarStoreID", new ConfigOption("calendarStoreID", new SerializationOptions("store", JsonMode.ToClientID), "", this.CalendarStoreID ));
                list.Add("fieldLabel", new ConfigOption("fieldLabel", null, "Calendar", this.FieldLabel ));
                list.Add("triggerAction", new ConfigOption("triggerAction", new SerializationOptions(JsonMode.ToLower), TriggerAction.All, this.TriggerAction ));
                list.Add("queryMode", new ConfigOption("queryMode", new SerializationOptions(JsonMode.ToLower), DataLoadMode.Local, this.QueryMode ));
                list.Add("forceSelection", new ConfigOption("forceSelection", null, true, this.ForceSelection ));
                list.Add("selectOnFocus", new ConfigOption("selectOnFocus", null, true, this.SelectOnFocus ));

                return list;
            }
        }
    }
}