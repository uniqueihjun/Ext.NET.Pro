/********
 * @version   : 2.1.0 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class GridPanelDirectEvents
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
                
                list.Add("groupClick", new ConfigOption("groupClick", new SerializationOptions("groupclick", typeof(DirectEventJsonConverter)), null, this.GroupClick ));
                list.Add("groupContextMenu", new ConfigOption("groupContextMenu", new SerializationOptions("groupcontextmenu", typeof(DirectEventJsonConverter)), null, this.GroupContextMenu ));
                list.Add("groupDblClick", new ConfigOption("groupDblClick", new SerializationOptions("groupdblclick", typeof(DirectEventJsonConverter)), null, this.GroupDblClick ));
                list.Add("groupCollapse", new ConfigOption("groupCollapse", new SerializationOptions("groupcollapse", typeof(DirectEventJsonConverter)), null, this.GroupCollapse ));
                list.Add("groupExpand", new ConfigOption("groupExpand", new SerializationOptions("groupexpand", typeof(DirectEventJsonConverter)), null, this.GroupExpand ));
                list.Add("reconfigure", new ConfigOption("reconfigure", new SerializationOptions("reconfigure", typeof(DirectEventJsonConverter)), null, this.Reconfigure ));

                return list;
            }
        }
    }
}