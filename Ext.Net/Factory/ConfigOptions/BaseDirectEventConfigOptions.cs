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
    public partial class BaseDirectEvent
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
                
                list.Add("cleanRequest", new ConfigOption("cleanRequest", null, false, this.CleanRequest ));
                list.Add("disableCaching", new ConfigOption("disableCaching", null, null, this.DisableCaching ));
                list.Add("disableCachingParam", new ConfigOption("disableCachingParam", null, "_dc", this.DisableCachingParam ));
                list.Add("isUpload", new ConfigOption("isUpload", null, false, this.IsUpload ));
                list.Add("json", new ConfigOption("json", null, false, this.Json ));
                list.Add("viewStateMode", new ConfigOption("viewStateMode", new SerializationOptions(JsonMode.ToLower), ViewStateMode.Inherit, this.ViewStateMode ));
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), DirectEventType.Submit, this.Type ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("method", new ConfigOption("method", new SerializationOptions("method"), HttpMethod.Default, this.Method ));
                list.Add("timeout", new ConfigOption("timeout", null, 30000, this.Timeout ));
                list.Add("formProxyArg", new ConfigOption("formProxyArg", new SerializationOptions("formId"), "", this.FormProxyArg ));
                list.Add("extraParams", new ConfigOption("extraParams", new SerializationOptions(JsonMode.ArrayToObject), null, this.ExtraParams ));
                list.Add("eventMask", new ConfigOption("eventMask", new SerializationOptions(JsonMode.Object), null, this.EventMask ));
                list.Add("showWarningOnFailure", new ConfigOption("showWarningOnFailure", null, true, this.ShowWarningOnFailure ));

                return list;
            }
        }
    }
}