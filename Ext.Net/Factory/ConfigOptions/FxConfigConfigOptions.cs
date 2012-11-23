/********
 * @version   : 1.6.0 - Ext.NET Pro License
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
    public partial class FxConfig
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
                
                list.Add("afterCls", new ConfigOption("afterCls", null, "", this.AfterCls ));
                list.Add("afterStyle", new ConfigOption("afterStyle", null, "", this.AfterStyle ));
                list.Add("block", new ConfigOption("block", null, false, this.Block ));
                list.Add("concurrent", new ConfigOption("concurrent", null, false, this.Concurrent ));
                list.Add("remove", new ConfigOption("remove", null, false, this.Remove ));
                list.Add("stopFx", new ConfigOption("stopFx", null, false, this.StopFx ));
                list.Add("useDisplay", new ConfigOption("useDisplay", null, false, this.UseDisplay ));

                return list;
            }
        }
    }
}