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
    public abstract partial class StoreBase
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
                
                list.Add("buffered", new ConfigOption("buffered", null, false, this.Buffered ));
                list.Add("clearOnPageLoad", new ConfigOption("clearOnPageLoad", null, true, this.ClearOnPageLoad ));
                list.Add("clearRemovedOnLoad", new ConfigOption("clearRemovedOnLoad", null, true, this.ClearRemovedOnLoad ));
                list.Add("dataProxy", new ConfigOption("dataProxy", new SerializationOptions("data", JsonMode.Raw), null, this.DataProxy ));
                list.Add("groupDir", new ConfigOption("groupDir", new SerializationOptions(JsonMode.ToLower), SortDirection.Default, this.GroupDir ));
                list.Add("groupField", new ConfigOption("groupField", null, "", this.GroupField ));
                list.Add("groupers", new ConfigOption("groupers", new SerializationOptions(JsonMode.Array), null, this.Groupers ));
                list.Add("leadingBufferZone", new ConfigOption("leadingBufferZone", null, 200, this.LeadingBufferZone ));
                list.Add("pageSize", new ConfigOption("pageSize", null, 25, this.PageSize ));
                list.Add("purgePageCount", new ConfigOption("purgePageCount", null, 5, this.PurgePageCount ));
                list.Add("remoteFilter", new ConfigOption("remoteFilter", null, false, this.RemoteFilter ));
                list.Add("remoteGroup", new ConfigOption("remoteGroup", null, false, this.RemoteGroup ));
                list.Add("remoteSort", new ConfigOption("remoteSort", null, false, this.RemoteSort ));
                list.Add("sortOnFilter", new ConfigOption("sortOnFilter", null, true, this.SortOnFilter ));
                list.Add("trailingBufferZone", new ConfigOption("trailingBufferZone", null, 25, this.TrailingBufferZone ));
                list.Add("warningOnDirty", new ConfigOption("warningOnDirty", null, false, this.WarningOnDirty ));
                list.Add("dirtyWarningTitle", new ConfigOption("dirtyWarningTitle", null, "Uncommitted Changes", this.DirtyWarningTitle ));
                list.Add("dirtyWarningText", new ConfigOption("dirtyWarningText", null, "You have uncommitted changes.  Are you sure you want to load/reload data?", this.DirtyWarningText ));

                return list;
            }
        }
    }
}