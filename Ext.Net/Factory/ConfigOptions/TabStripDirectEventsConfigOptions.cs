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
    public partial class TabStripDirectEvents
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
                
                list.Add("beforeTabChange", new ConfigOption("beforeTabChange", new SerializationOptions("beforetabchange", typeof(DirectEventJsonConverter)), null, this.BeforeTabChange ));
                list.Add("contextMenu", new ConfigOption("contextMenu", new SerializationOptions("contextmenu", typeof(DirectEventJsonConverter)), null, this.ContextMenu ));
                list.Add("tabChange", new ConfigOption("tabChange", new SerializationOptions("tabchange", typeof(DirectEventJsonConverter)), null, this.TabChange ));
                list.Add("tabClose", new ConfigOption("tabClose", new SerializationOptions("tabclose", typeof(DirectEventJsonConverter)), null, this.TabClose ));
                list.Add("beforeTabClose", new ConfigOption("beforeTabClose", new SerializationOptions("beforetabclose", typeof(DirectEventJsonConverter)), null, this.BeforeTabClose ));

                return list;
            }
        }
    }
}