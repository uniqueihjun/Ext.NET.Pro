/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class AjaxOptions
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
                
                list.Add("disableCaching", new ConfigOption("disableCaching", null, true, this.DisableCaching ));
                list.Add("disableCachingParam", new ConfigOption("disableCachingParam", null, "_dc", this.DisableCachingParam ));
                list.Add("timeout", new ConfigOption("timeout", null, 30000, this.Timeout ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("method", new ConfigOption("method", null, HttpMethod.Default, this.Method ));
                list.Add("isUpload", new ConfigOption("isUpload", null, false, this.IsUpload ));
                list.Add("json", new ConfigOption("json", null, false, this.Json ));
                list.Add("xml", new ConfigOption("xml", null, false, this.Xml ));
                list.Add("formProxyArg", new ConfigOption("formProxyArg", new SerializationOptions("form"), "", this.FormProxyArg ));
                list.Add("headers", new ConfigOption("headers", new SerializationOptions(JsonMode.ArrayToObject), null, this.Headers ));
                list.Add("params", new ConfigOption("params", new SerializationOptions(JsonMode.ArrayToObject), null, this.Params ));
                list.Add("callbackProxy", new ConfigOption("callbackProxy", new SerializationOptions("callback", JsonMode.Raw), "", this.CallbackProxy ));

                return list;
            }
        }
    }
}