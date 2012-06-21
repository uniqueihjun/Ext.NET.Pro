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
    public abstract partial class TableView
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
                
                list.Add("getRowClass", new ConfigOption("getRowClass", new SerializationOptions(JsonMode.Raw), null, this.GetRowClass ));
                list.Add("enableTextSelection", new ConfigOption("enableTextSelection", null, false, this.EnableTextSelection ));
                list.Add("firstCls", new ConfigOption("firstCls", null, "x-grid-cell-first", this.FirstCls ));
                list.Add("lastCls", new ConfigOption("lastCls", null, "x-grid-cell-last", this.LastCls ));
                list.Add("markDirty", new ConfigOption("markDirty", null, true, this.MarkDirty ));
                list.Add("trackOver", new ConfigOption("trackOver", null, true, this.TrackOver ));

                return list;
            }
        }
    }
}