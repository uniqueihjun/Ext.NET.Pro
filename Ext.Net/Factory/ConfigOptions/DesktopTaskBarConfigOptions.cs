/********
 * @version   : 2.0.0.rc1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
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
    public partial class DesktopTaskBar
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
                
                list.Add("quickStart", new ConfigOption("quickStart", new SerializationOptions("quickStartConfig", typeof(SingleItemCollectionJsonConverter)), null, this.QuickStart ));
                list.Add("tray", new ConfigOption("tray", new SerializationOptions("trayConfig", typeof(SingleItemCollectionJsonConverter)), null, this.Tray ));
                list.Add("hideQuickStart", new ConfigOption("hideQuickStart", null, false, this.HideQuickStart ));
                list.Add("hideTray", new ConfigOption("hideTray", null, false, this.HideTray ));
                list.Add("quickStartWidth", new ConfigOption("quickStartWidth", null, 60, this.QuickStartWidth ));
                list.Add("trayWidth", new ConfigOption("trayWidth", null, 80, this.TrayWidth ));
                list.Add("trayClock", new ConfigOption("trayClock", new SerializationOptions("trayClock", typeof(LazyControlJsonConverter)), null, this.TrayClock ));

                return list;
            }
        }
    }
}