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
    public partial class ShortcutDefaults
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
                
                list.Add("iconCls", new ConfigOption("iconCls", null, "", this.IconCls ));
                list.Add("name", new ConfigOption("name", null, "", this.Name ));
                list.Add("textCls", new ConfigOption("textCls", null, "", this.TextCls ));
                list.Add("handler", new ConfigOption("handler", new SerializationOptions(JsonMode.Raw), "", this.Handler ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));
                list.Add("qTitle", new ConfigOption("qTitle", new SerializationOptions("qTitle"), "", this.QTitle ));
                list.Add("qTip", new ConfigOption("qTip", new SerializationOptions("qTip"), "", this.QTip ));

                return list;
            }
        }
    }
}