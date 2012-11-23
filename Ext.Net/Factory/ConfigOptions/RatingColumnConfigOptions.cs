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
    public partial class RatingColumn
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
                
                list.Add("xType", new ConfigOption("xType", new SerializationOptions("xtype"), "", this.XType ));
                list.Add("fixed", new ConfigOption("fixed", null, true, this.Fixed ));
                list.Add("dataIndex", new ConfigOption("dataIndex", null, "rating", this.DataIndex ));
                list.Add("editable", new ConfigOption("editable", null, false, this.Editable ));
                list.Add("allowChange", new ConfigOption("allowChange", null, true, this.AllowChange ));
                list.Add("selectedCls", new ConfigOption("selectedCls", null, "rating-selected", this.SelectedCls ));
                list.Add("unselectedCls", new ConfigOption("unselectedCls", null, "rating-unselected", this.UnselectedCls ));
                list.Add("maxRating", new ConfigOption("maxRating", null, 5, this.MaxRating ));
                list.Add("tickSize", new ConfigOption("tickSize", null, 16, this.TickSize ));
                list.Add("roundToTick", new ConfigOption("roundToTick", null, true, this.RoundToTick ));

                return list;
            }
        }
    }
}