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
    public partial class ComponentListener
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
                
                list.Add("autoPostBack", new ConfigOption("autoPostBack", null, false, this.AutoPostBack ));
                list.Add("fnInternal", new ConfigOption("fnInternal", new SerializationOptions("fn", JsonMode.Raw), "", this.FnInternal ));
                list.Add("broadcastOnBus", new ConfigOption("broadcastOnBus", null, "", this.BroadcastOnBus ));
                list.Add("argumentsListProxy", new ConfigOption("argumentsListProxy", new SerializationOptions("argumentsList", JsonMode.AlwaysArray), null, this.ArgumentsListProxy ));

                return list;
            }
        }
    }
}