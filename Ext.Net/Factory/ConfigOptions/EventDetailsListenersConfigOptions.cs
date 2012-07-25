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
    public partial class EventDetailsListeners
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
                
                list.Add("eventAdd", new ConfigOption("eventAdd", new SerializationOptions("eventadd", typeof(ListenerJsonConverter)), null, this.EventAdd ));
                list.Add("eventCancel", new ConfigOption("eventCancel", new SerializationOptions("eventcancel", typeof(ListenerJsonConverter)), null, this.EventCancel ));
                list.Add("eventDelete", new ConfigOption("eventDelete", new SerializationOptions("eventdelete", typeof(ListenerJsonConverter)), null, this.EventDelete ));
                list.Add("eventUpdate", new ConfigOption("eventUpdate", new SerializationOptions("eventupdate", typeof(ListenerJsonConverter)), null, this.EventUpdate ));

                return list;
            }
        }
    }
}