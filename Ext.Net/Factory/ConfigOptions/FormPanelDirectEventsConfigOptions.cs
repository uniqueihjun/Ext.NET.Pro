/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class FormPanelDirectEvents
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
                
                list.Add("actionComplete", new ConfigOption("actionComplete", new SerializationOptions("actioncomplete", typeof(DirectEventJsonConverter)), null, this.ActionComplete ));
                list.Add("actionFailed", new ConfigOption("actionFailed", new SerializationOptions("actionfailed", typeof(DirectEventJsonConverter)), null, this.ActionFailed ));
                list.Add("beforeAction", new ConfigOption("beforeAction", new SerializationOptions("beforeaction", typeof(DirectEventJsonConverter)), null, this.BeforeAction ));
                list.Add("dirtyChange", new ConfigOption("dirtyChange", new SerializationOptions("dirtychange", typeof(DirectEventJsonConverter)), null, this.DirtyChange ));
                list.Add("validityChange", new ConfigOption("validityChange", new SerializationOptions("validitychange", typeof(DirectEventJsonConverter)), null, this.ValidityChange ));
                list.Add("fieldErrorChange", new ConfigOption("fieldErrorChange", new SerializationOptions("fielderrorchange", typeof(DirectEventJsonConverter)), null, this.FieldErrorChange ));
                list.Add("fieldValidityChange", new ConfigOption("fieldValidityChange", new SerializationOptions("fieldvaliditychange", typeof(DirectEventJsonConverter)), null, this.FieldValidityChange ));
                list.Add("fieldChange", new ConfigOption("fieldChange", new SerializationOptions("fieldchange", typeof(DirectEventJsonConverter)), null, this.FieldChange ));

                return list;
            }
        }
    }
}