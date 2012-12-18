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
    public partial class BaseLoadConfig
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
                
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("callbackProxy", new ConfigOption("callbackProxy", new SerializationOptions("callback", JsonMode.Raw), "", this.CallbackProxy ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "", this.Scope ));
                list.Add("discardUrl", new ConfigOption("discardUrl", null, false, this.DiscardUrl ));
                list.Add("noCache", new ConfigOption("noCache", new SerializationOptions("nocache"), false, this.NoCache ));
                list.Add("text", new ConfigOption("text", null, "", this.Text ));
                list.Add("scriptsProxy", new ConfigOption("scriptsProxy", new SerializationOptions("scripts"), false, this.ScriptsProxy ));
                list.Add("timeout", new ConfigOption("timeout", null, 0, this.Timeout ));
                list.Add("params", new ConfigOption("params", new SerializationOptions(JsonMode.ArrayToObject), null, this.Params ));
                list.Add("method", new ConfigOption("method", new SerializationOptions("method"), HttpMethod.Default, this.Method ));

                return list;
            }
        }
    }
}