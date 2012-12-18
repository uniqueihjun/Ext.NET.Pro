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
    public partial class Task
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
                
                list.Add("taskID", new ConfigOption("taskID", new SerializationOptions("id"), "", this.TaskID ));
                list.Add("autoRun", new ConfigOption("autoRun", null, true, this.AutoRun ));
                list.Add("waitPreviousRequest", new ConfigOption("waitPreviousRequest", null, false, this.WaitPreviousRequest ));
                list.Add("interval", new ConfigOption("interval", null, 1000, this.Interval ));
                list.Add("args", new ConfigOption("args", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.Args ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "this", this.Scope ));
                list.Add("duration", new ConfigOption("duration", null, 0, this.Duration ));
                list.Add("repeat", new ConfigOption("repeat", null, 0, this.Repeat ));
                list.Add("directEventProxy", new ConfigOption("directEventProxy", new SerializationOptions("serverRun", JsonMode.Raw), "", this.DirectEventProxy ));
                list.Add("listenerProxy", new ConfigOption("listenerProxy", new SerializationOptions("clientRun", JsonMode.Raw), "", this.ListenerProxy ));
                list.Add("onStart", new ConfigOption("onStart", new SerializationOptions("onstart", typeof(FunctionJsonConverter)), "", this.OnStart ));
                list.Add("onStop", new ConfigOption("onStop", new SerializationOptions("onstop", typeof(FunctionJsonConverter)), "", this.OnStop ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}