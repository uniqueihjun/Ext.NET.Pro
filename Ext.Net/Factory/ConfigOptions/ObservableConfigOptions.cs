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
    public abstract partial class Observable
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
                
                list.Add("customConfig", new ConfigOption("customConfig", new SerializationOptions("-", typeof(CustomConfigJsonConverter)), null, this.CustomConfig ));
                list.Add("configsProxy", new ConfigOption("configsProxy", new SerializationOptions("-", typeof(ConfigBagJsonConverter)), null, this.ConfigsProxy ));
                list.Add("messageBusListenersProxy", new ConfigOption("messageBusListenersProxy", new SerializationOptions("messageBusListeners", JsonMode.Raw), "", this.MessageBusListenersProxy ));
                list.Add("messageBusDirectEventsProxy", new ConfigOption("messageBusDirectEventsProxy", new SerializationOptions("messageBusDirectEvents", JsonMode.Raw), "", this.MessageBusDirectEventsProxy ));

                return list;
            }
        }
    }
}