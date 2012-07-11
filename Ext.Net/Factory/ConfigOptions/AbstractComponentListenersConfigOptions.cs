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
    public partial class AbstractComponentListeners
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
                
                list.Add("activate", new ConfigOption("activate", new SerializationOptions("activate", typeof(ListenerJsonConverter)), null, this.Activate ));
                list.Add("added", new ConfigOption("added", new SerializationOptions("added", typeof(ListenerJsonConverter)), null, this.Added ));
                list.Add("afterRender", new ConfigOption("afterRender", new SerializationOptions("afterrender", typeof(ListenerJsonConverter)), null, this.AfterRender ));
                list.Add("beforeActivate", new ConfigOption("beforeActivate", new SerializationOptions("beforeactivate", typeof(ListenerJsonConverter)), null, this.BeforeActivate ));
                list.Add("beforeDeactivate", new ConfigOption("beforeDeactivate", new SerializationOptions("beforedeactivate", typeof(ListenerJsonConverter)), null, this.BeforeDeactivate ));
                list.Add("beforeDestroy", new ConfigOption("beforeDestroy", new SerializationOptions("beforedestroy", typeof(ListenerJsonConverter)), null, this.BeforeDestroy ));
                list.Add("beforeHide", new ConfigOption("beforeHide", new SerializationOptions("beforehide", typeof(ListenerJsonConverter)), null, this.BeforeHide ));
                list.Add("beforeRender", new ConfigOption("beforeRender", new SerializationOptions("beforerender", typeof(ListenerJsonConverter)), null, this.BeforeRender ));
                list.Add("beforeShow", new ConfigOption("beforeShow", new SerializationOptions("beforeshow", typeof(ListenerJsonConverter)), null, this.BeforeShow ));
                list.Add("deactivate", new ConfigOption("deactivate", new SerializationOptions("deactivate", typeof(ListenerJsonConverter)), null, this.Deactivate ));
                list.Add("destroy", new ConfigOption("destroy", new SerializationOptions("destroy", typeof(ListenerJsonConverter)), null, this.Destroy ));
                list.Add("disable", new ConfigOption("disable", new SerializationOptions("disable", typeof(ListenerJsonConverter)), null, this.Disable ));
                list.Add("enable", new ConfigOption("enable", new SerializationOptions("enable", typeof(ListenerJsonConverter)), null, this.Enable ));
                list.Add("hide", new ConfigOption("hide", new SerializationOptions("hide", typeof(ListenerJsonConverter)), null, this.Hide ));
                list.Add("move", new ConfigOption("move", new SerializationOptions("move", typeof(ListenerJsonConverter)), null, this.Move ));
                list.Add("removed", new ConfigOption("removed", new SerializationOptions("removed", typeof(ListenerJsonConverter)), null, this.Removed ));
                list.Add("render", new ConfigOption("render", new SerializationOptions("render", typeof(ListenerJsonConverter)), null, this.Render ));
                list.Add("resize", new ConfigOption("resize", new SerializationOptions("resize", typeof(ListenerJsonConverter)), null, this.Resize ));
                list.Add("show", new ConfigOption("show", new SerializationOptions("show", typeof(ListenerJsonConverter)), null, this.Show ));
                list.Add("beforeStateRestore", new ConfigOption("beforeStateRestore", new SerializationOptions("beforestaterestore", typeof(ListenerJsonConverter)), null, this.BeforeStateRestore ));
                list.Add("beforeStateSave", new ConfigOption("beforeStateSave", new SerializationOptions("beforestatesave", typeof(ListenerJsonConverter)), null, this.BeforeStateSave ));
                list.Add("stateRestore", new ConfigOption("stateRestore", new SerializationOptions("staterestore", typeof(ListenerJsonConverter)), null, this.StateRestore ));
                list.Add("stateSave", new ConfigOption("stateSave", new SerializationOptions("statesave", typeof(ListenerJsonConverter)), null, this.StateSave ));
                list.Add("blur", new ConfigOption("blur", new SerializationOptions("blur", typeof(ListenerJsonConverter)), null, this.Blur ));
                list.Add("focus", new ConfigOption("focus", new SerializationOptions("focus", typeof(ListenerJsonConverter)), null, this.Focus ));
                list.Add("boxReady", new ConfigOption("boxReady", new SerializationOptions("boxready", typeof(ListenerJsonConverter)), null, this.BoxReady ));

                return list;
            }
        }
    }
}