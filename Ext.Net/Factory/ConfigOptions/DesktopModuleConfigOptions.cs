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
    public partial class DesktopModule
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
                
                list.Add("moduleID", new ConfigOption("moduleID", new SerializationOptions("id"), "", this.ModuleID ));
                list.Add("windowProxy", new ConfigOption("windowProxy", new SerializationOptions("windowID"), "", this.WindowProxy ));
                list.Add("launcherProxy", new ConfigOption("launcherProxy", new SerializationOptions("launcher",JsonMode.Raw), "", this.LauncherProxy ));
                list.Add("autoRun", new ConfigOption("autoRun", null, false, this.AutoRun ));

                return list;
            }
        }
    }
}