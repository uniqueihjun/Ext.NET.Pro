/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class TabStrip
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
                
                list.Add("tabPosition", new ConfigOption("tabPosition", new SerializationOptions(JsonMode.ToLower), TabPosition.Top, this.TabPosition ));
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", JsonMode.AlwaysArray), null, this.Items ));
                list.Add("actionContainerProxy", new ConfigOption("actionContainerProxy", new SerializationOptions("actionContainer"), "", this.ActionContainerProxy ));
                list.Add("activeTabIndex", new ConfigOption("activeTabIndex", new SerializationOptions("activeTab"), -1, this.ActiveTabIndex ));
                list.Add("minTabWidth", new ConfigOption("minTabWidth", null, 0, this.MinTabWidth ));
                list.Add("maxTabWidth", new ConfigOption("maxTabWidth", null, int.MaxValue, this.MaxTabWidth ));
                list.Add("plain", new ConfigOption("plain", null, true, this.Plain ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}