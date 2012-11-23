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
    public abstract partial class FormPanelBase
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
                
                list.Add("pollInterval", new ConfigOption("pollInterval", null, 500, this.PollInterval ));
                list.Add("pollForChanges", new ConfigOption("pollForChanges", null, false, this.PollForChanges ));
                list.Add("errorReader", new ConfigOption("errorReader", new SerializationOptions("errorReader>PrimaryProxy"), null, this.ErrorReader ));
                list.Add("method", new ConfigOption("method", new SerializationOptions("method"), HttpMethod.Default, this.Method ));
                list.Add("reader", new ConfigOption("reader", new SerializationOptions("reader>PrimaryProxy"), null, this.Reader ));
                list.Add("standardSubmit", new ConfigOption("standardSubmit", null, false, this.StandardSubmit ));
                list.Add("timeout", new ConfigOption("timeout", null, 30, this.Timeout ));
                list.Add("trackResetOnLoad", new ConfigOption("trackResetOnLoad", null, false, this.TrackResetOnLoad ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("waitMsgTarget", new ConfigOption("waitMsgTarget", null, "", this.WaitMsgTarget ));
                list.Add("waitTitle", new ConfigOption("waitTitle", null, "Please Wait...", this.WaitTitle ));
                list.Add("jsonSubmit", new ConfigOption("jsonSubmit", null, false, this.JsonSubmit ));
                list.Add("fieldDefaults", new ConfigOption("fieldDefaults", new SerializationOptions(JsonMode.Object), null, this.FieldDefaults ));

                return list;
            }
        }
    }
}