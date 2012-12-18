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
    public partial class FormPanelListeners
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
                
                list.Add("actionComplete", new ConfigOption("actionComplete", new SerializationOptions("actioncomplete", typeof(ListenerJsonConverter)), null, this.ActionComplete ));
                list.Add("actionFailed", new ConfigOption("actionFailed", new SerializationOptions("actionfailed", typeof(ListenerJsonConverter)), null, this.ActionFailed ));
                list.Add("beforeAction", new ConfigOption("beforeAction", new SerializationOptions("beforeaction", typeof(ListenerJsonConverter)), null, this.BeforeAction ));
                list.Add("dirtyChange", new ConfigOption("dirtyChange", new SerializationOptions("dirtychange", typeof(ListenerJsonConverter)), null, this.DirtyChange ));
                list.Add("validityChange", new ConfigOption("validityChange", new SerializationOptions("validitychange", typeof(ListenerJsonConverter)), null, this.ValidityChange ));
                list.Add("fieldErrorChange", new ConfigOption("fieldErrorChange", new SerializationOptions("fielderrorchange", typeof(ListenerJsonConverter)), null, this.FieldErrorChange ));
                list.Add("fieldValidityChange", new ConfigOption("fieldValidityChange", new SerializationOptions("fieldvaliditychange", typeof(ListenerJsonConverter)), null, this.FieldValidityChange ));
                list.Add("fieldChange", new ConfigOption("fieldChange", new SerializationOptions("fieldchange", typeof(ListenerJsonConverter)), null, this.FieldChange ));

                return list;
            }
        }
    }
}