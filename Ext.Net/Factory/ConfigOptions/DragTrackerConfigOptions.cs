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
    public partial class DragTracker
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
                
                list.Add("trackOver", new ConfigOption("trackOver", null, false, this.TrackOver ));
                list.Add("tolerance", new ConfigOption("tolerance", null, 5, this.Tolerance ));
                list.Add("autoStart", new ConfigOption("autoStart", null, 0, this.AutoStart ));
                list.Add("proxyCls", new ConfigOption("proxyCls", null, "x-view-selector", this.ProxyCls ));
                list.Add("overCls", new ConfigOption("overCls", null, "", this.OverCls ));
                list.Add("constrainTo", new ConfigOption("constrainTo", null, "", this.ConstrainTo ));
                list.Add("delegate", new ConfigOption("delegate", null, "", this.Delegate ));
                list.Add("preventDefault", new ConfigOption("preventDefault", null, true, this.PreventDefault ));
                list.Add("stopEvent", new ConfigOption("stopEvent", null, false, this.StopEvent ));
                list.Add("target", new ConfigOption("target", new SerializationOptions("el"), "", this.Target ));
                list.Add("onBeforeStart", new ConfigOption("onBeforeStart", new SerializationOptions(JsonMode.Raw), null, this.OnBeforeStart ));
                list.Add("onStart", new ConfigOption("onStart", new SerializationOptions(JsonMode.Raw), null, this.OnStart ));
                list.Add("onDrag", new ConfigOption("onDrag", new SerializationOptions(JsonMode.Raw), null, this.OnDrag ));
                list.Add("onEnd", new ConfigOption("onEnd", new SerializationOptions(JsonMode.Raw), null, this.OnEnd ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}