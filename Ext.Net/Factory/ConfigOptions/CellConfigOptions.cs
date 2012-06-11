/********
 * @version   : 1.3.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-02-21
 * @copyright : Copyright (c) 2007-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class Cell
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
                
                list.Add("rowSpan", new ConfigOption("rowSpan", new SerializationOptions("rowspan", JsonMode.Raw), 0, this.RowSpan ));
                list.Add("colSpan", new ConfigOption("colSpan", new SerializationOptions("colspan", JsonMode.Raw), 0, this.ColSpan ));
                list.Add("cellCls", new ConfigOption("cellCls", null, "", this.CellCls ));
                list.Add("cellId", new ConfigOption("cellId", null, "", this.CellId ));

                return list;
            }
        }
    }
}