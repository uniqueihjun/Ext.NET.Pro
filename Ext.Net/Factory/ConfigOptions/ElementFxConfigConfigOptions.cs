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
    public partial class ElementFxConfig
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
                
                list.Add("callback", new ConfigOption("callback", new SerializationOptions(JsonMode.Raw), null, this.Callback ));
                list.Add("duration", new ConfigOption("duration", null, 0.0, this.Duration ));
                list.Add("easing", new ConfigOption("easing", new SerializationOptions(JsonMode.ToCamelLower), Easing.EaseOut, this.Easing ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "this", this.Scope ));

                return list;
            }
        }
    }
}