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
    public partial class GroupingView
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
                
                list.Add("emptyGroupText", new ConfigOption("emptyGroupText", null, "", this.EmptyGroupText ));
                list.Add("enableGrouping", new ConfigOption("enableGrouping", null, true, this.EnableGrouping ));
                list.Add("enableGroupingMenu", new ConfigOption("enableGroupingMenu", null, true, this.EnableGroupingMenu ));
                list.Add("enableNoGroups", new ConfigOption("enableNoGroups", null, true, this.EnableNoGroups ));
                list.Add("groupByText", new ConfigOption("groupByText", null, "Group By This Field", this.GroupByText ));
                list.Add("groupTextTpl", new ConfigOption("groupTextTpl", null, "", this.GroupTextTpl ));
                list.Add("header", new ConfigOption("header", null, "", this.Header ));
                list.Add("hideGroupedColumn", new ConfigOption("hideGroupedColumn", null, false, this.HideGroupedColumn ));
                list.Add("ignoreAdd", new ConfigOption("ignoreAdd", null, false, this.IgnoreAdd ));
                list.Add("showGroupName", new ConfigOption("showGroupName", null, true, this.ShowGroupName ));
                list.Add("showGroupsText", new ConfigOption("showGroupsText", null, "Show in Groups", this.ShowGroupsText ));
                list.Add("startCollapsed", new ConfigOption("startCollapsed", null, false, this.StartCollapsed ));

                return list;
            }
        }
    }
}