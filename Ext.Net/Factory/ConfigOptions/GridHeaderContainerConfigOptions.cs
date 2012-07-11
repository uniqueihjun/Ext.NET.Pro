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
    public partial class GridHeaderContainer
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
                
                list.Add("defaultWidth", new ConfigOption("defaultWidth", null, 100, this.DefaultWidth ));
                list.Add("weight", new ConfigOption("weight", null, 100, this.Weight ));
                list.Add("sortable", new ConfigOption("sortable", null, null, this.Sortable ));
                list.Add("sortAscText", new ConfigOption("sortAscText", null, "", this.SortAscText ));
                list.Add("sortDescText", new ConfigOption("sortDescText", null, "", this.SortDescText ));
                list.Add("sortClearText", new ConfigOption("sortClearText", null, "", this.SortClearText ));
                list.Add("columnsText", new ConfigOption("columnsText", null, "", this.ColumnsText ));
                list.Add("itemsProxy", new ConfigOption("itemsProxy", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.ItemsProxy ));
                list.Add("forceFit", new ConfigOption("forceFit", null, false, this.ForceFit ));
                list.Add("enableColumnMove", new ConfigOption("enableColumnMove", null, true, this.EnableColumnMove ));
                list.Add("enableColumnResize", new ConfigOption("enableColumnResize", null, true, this.EnableColumnResize ));
                list.Add("enableColumnHide", new ConfigOption("enableColumnHide", null, true, this.EnableColumnHide ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}