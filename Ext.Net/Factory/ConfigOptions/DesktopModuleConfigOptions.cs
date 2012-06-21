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
                list.Add("windowProxy", new ConfigOption("windowProxy", new SerializationOptions("window", JsonMode.Raw), "", this.WindowProxy ));
                list.Add("launcher", new ConfigOption("launcher", new SerializationOptions("launcher", typeof(LazyControlJsonConverter)), null, this.Launcher ));
                list.Add("shortcut", new ConfigOption("shortcut", new SerializationOptions(JsonMode.Object), null, this.Shortcut ));
                list.Add("autoRun", new ConfigOption("autoRun", null, false, this.AutoRun ));
                list.Add("autoRunHandler", new ConfigOption("autoRunHandler", new SerializationOptions(JsonMode.Raw), "", this.AutoRunHandler ));

                return list;
            }
        }
    }
}