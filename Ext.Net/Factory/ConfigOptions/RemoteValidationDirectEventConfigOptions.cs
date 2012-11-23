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
    public partial class RemoteValidationDirectEvent
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
                
                list.Add("validationBuffer", new ConfigOption("validationBuffer", null, 500, this.ValidationBuffer ));
                list.Add("showBusy", new ConfigOption("showBusy", null, true, this.ShowBusy ));
                list.Add("busyTip", new ConfigOption("busyTip", null, "Validating...", this.BusyTip ));
                list.Add("busyIconClsProxy", new ConfigOption("busyIconClsProxy", new SerializationOptions("busyIconCls"), "", this.BusyIconClsProxy ));
                list.Add("busyIconCls", new ConfigOption("busyIconCls", null, "loading-indicator", this.BusyIconCls ));
                list.Add("validationEvent", new ConfigOption("validationEvent", new SerializationOptions(JsonMode.ToLower), "keyup", this.ValidationEvent ));
                list.Add("eventOwner", new ConfigOption("eventOwner", new SerializationOptions(JsonMode.ToLower), ValidationEventOwner.Element, this.EventOwner ));
                list.Add("initValueValidation", new ConfigOption("initValueValidation", new SerializationOptions(JsonMode.ToLower), InitValueValidation.Valid, this.InitValueValidation ));

                return list;
            }
        }
    }
}