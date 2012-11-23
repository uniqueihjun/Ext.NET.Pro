/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class ReminderCombo
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
                
                list.Add("fieldLabel", new ConfigOption("fieldLabel", null, "Reminder", this.FieldLabel ));
                list.Add("triggerAction", new ConfigOption("triggerAction", new SerializationOptions(JsonMode.ToLower), TriggerAction.All, this.TriggerAction ));
                list.Add("queryMode", new ConfigOption("queryMode", new SerializationOptions(JsonMode.ToLower), DataLoadMode.Local, this.QueryMode ));
                list.Add("forceSelection", new ConfigOption("forceSelection", null, true, this.ForceSelection ));
                list.Add("displayField", new ConfigOption("displayField", null, "desc", this.DisplayField ));
                list.Add("valueField", new ConfigOption("valueField", null, "value", this.ValueField ));

                return list;
            }
        }
    }
}