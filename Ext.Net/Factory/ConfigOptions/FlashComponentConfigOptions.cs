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
    public partial class FlashComponent
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
                
                list.Add("expressInstall", new ConfigOption("expressInstall", null, false, this.ExpressInstall ));
                list.Add("url", new ConfigOption("url", new SerializationOptions(JsonMode.Url), "", this.Url ));
                list.Add("flashVars", new ConfigOption("flashVars", new SerializationOptions(JsonMode.ArrayToObject), null, this.FlashVars ));
                list.Add("flashParams", new ConfigOption("flashParams", new SerializationOptions(JsonMode.ArrayToObject), null, this.FlashParams ));
                list.Add("swfHeight", new ConfigOption("swfHeight", null, "", this.SwfHeight ));
                list.Add("swfWidth", new ConfigOption("swfWidth", null, "", this.SwfWidth ));
                list.Add("wMode", new ConfigOption("wMode", new SerializationOptions("wmode"), "", this.WMode ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}