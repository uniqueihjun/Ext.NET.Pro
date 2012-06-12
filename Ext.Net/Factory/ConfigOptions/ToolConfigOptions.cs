/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class Tool
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
                
                list.Add("type", new ConfigOption("type", new SerializationOptions("id", JsonMode.ToLower), ToolType.None, this.Type ));
                list.Add("customType", new ConfigOption("customType", new SerializationOptions("id"), "", this.CustomType ));
                list.Add("fnProxy", new ConfigOption("fnProxy", new SerializationOptions("handler", JsonMode.Raw), "", this.FnProxy ));
                list.Add("scope", new ConfigOption("scope", new SerializationOptions(JsonMode.Raw), "this", this.Scope ));
                list.Add("qtip", new ConfigOption("qtip", null, "", this.Qtip ));
                list.Add("qTipCfg", new ConfigOption("qTipCfg", new SerializationOptions("qtip", JsonMode.Object), null, this.QTipCfg ));
                list.Add("hidden", new ConfigOption("hidden", null, false, this.Hidden ));

                return list;
            }
        }
    }
}