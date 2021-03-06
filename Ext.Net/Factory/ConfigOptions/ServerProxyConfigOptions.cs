/********
 * @version   : 2.1.1 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public abstract partial class ServerProxy
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
                
                list.Add("aPI", new ConfigOption("aPI", new SerializationOptions("api", JsonMode.Object), null, this.API ));
                list.Add("cacheString", new ConfigOption("cacheString", null, "_dc", this.CacheString ));
                list.Add("directionParam", new ConfigOption("directionParam", null, "dir", this.DirectionParam ));
                list.Add("extraParams", new ConfigOption("extraParams", new SerializationOptions(JsonMode.ArrayToObject), null, this.ExtraParams ));
                list.Add("filterParam", new ConfigOption("filterParam", null, "filter", this.FilterParam ));
                list.Add("groupParam", new ConfigOption("groupParam", null, "group", this.GroupParam ));
                list.Add("groupDirectionParam", new ConfigOption("groupDirectionParam", null, "groupDir", this.GroupDirectionParam ));
                list.Add("iDParam", new ConfigOption("iDParam", new SerializationOptions("idParam"), "id", this.IDParam ));
                list.Add("limitParam", new ConfigOption("limitParam", null, "limit", this.LimitParam ));
                list.Add("noCache", new ConfigOption("noCache", null, true, this.NoCache ));
                list.Add("appendAction", new ConfigOption("appendAction", null, true, this.AppendAction ));
                list.Add("pageParam", new ConfigOption("pageParam", null, "page", this.PageParam ));
                list.Add("reader", new ConfigOption("reader", new SerializationOptions("reader>PrimaryProxy"), null, this.Reader ));
                list.Add("simpleSortMode", new ConfigOption("simpleSortMode", null, false, this.SimpleSortMode ));
                list.Add("simpleGroupMode", new ConfigOption("simpleGroupMode", null, false, this.SimpleGroupMode ));
                list.Add("sortParam", new ConfigOption("sortParam", null, "sort", this.SortParam ));
                list.Add("startParam", new ConfigOption("startParam", null, "start", this.StartParam ));
                list.Add("timeout", new ConfigOption("timeout", new SerializationOptions(JsonMode.Raw), 30000, this.Timeout ));
                list.Add("urlProxy", new ConfigOption("urlProxy", new SerializationOptions("url"), "", this.UrlProxy ));
                list.Add("writer", new ConfigOption("writer", new SerializationOptions("writer>Primary"), null, this.Writer ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("buildUrl", new ConfigOption("buildUrl", new SerializationOptions(JsonMode.Raw), null, this.BuildUrl ));

                return list;
            }
        }
    }
}