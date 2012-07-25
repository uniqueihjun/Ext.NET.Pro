/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class Grouping
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
                
                list.Add("fType", new ConfigOption("fType", new SerializationOptions("ftype"), "", this.FType ));
                list.Add("depthToIndent", new ConfigOption("depthToIndent", null, 17, this.DepthToIndent ));
                list.Add("enableGroupingMenu", new ConfigOption("enableGroupingMenu", null, true, this.EnableGroupingMenu ));
                list.Add("enableNoGroups", new ConfigOption("enableNoGroups", null, true, this.EnableNoGroups ));
                list.Add("groupByText", new ConfigOption("groupByText", null, "", this.GroupByText ));
                list.Add("groupHeaderTplString", new ConfigOption("groupHeaderTplString", new SerializationOptions("groupHeaderTpl"), "", this.GroupHeaderTplString ));
                list.Add("groupHeaderTpl", new ConfigOption("groupHeaderTpl", new SerializationOptions("groupHeaderTpl", typeof(LazyControlJsonConverter)), null, this.GroupHeaderTpl ));
                list.Add("hideGroupedHeader", new ConfigOption("hideGroupedHeader", null, false, this.HideGroupedHeader ));
                list.Add("showGroupsText", new ConfigOption("showGroupsText", null, "", this.ShowGroupsText ));
                list.Add("startCollapsed", new ConfigOption("startCollapsed", null, false, this.StartCollapsed ));

                return list;
            }
        }
    }
}