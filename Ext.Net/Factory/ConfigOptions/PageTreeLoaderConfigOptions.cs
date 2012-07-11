/********
 * @version   : 1.5.0 - Ext.NET Pro License
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
    public partial class PageTreeLoader
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
                
                list.Add("isUpload", new ConfigOption("isUpload", null, false, this.IsUpload ));
                list.Add("viewStateMode", new ConfigOption("viewStateMode", new SerializationOptions(JsonMode.ToLower), ViewStateMode.Inherit, this.ViewStateMode ));
                list.Add("type", new ConfigOption("type", new SerializationOptions(JsonMode.ToLower), DirectEventType.Submit, this.Type ));
                list.Add("requestMethod", new ConfigOption("requestMethod", new SerializationOptions(JsonMode.Ignore), HttpMethod.Default, this.RequestMethod ));
                list.Add("methodProxy", new ConfigOption("methodProxy", new SerializationOptions("method"), HttpMethod.Default, this.MethodProxy ));
                list.Add("formProxyArg", new ConfigOption("formProxyArg", null, "", this.FormProxyArg ));
                list.Add("eventMask", new ConfigOption("eventMask", new SerializationOptions(JsonMode.Object), null, this.EventMask ));

                return list;
            }
        }
    }
}