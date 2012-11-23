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
    public partial class TreeGrid
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
                
                list.Add("autoExpandColumn", new ConfigOption("autoExpandColumn", null, "", this.AutoExpandColumn ));
                list.Add("autoExpandMax", new ConfigOption("autoExpandMax", null, Unit.Pixel(1000), this.AutoExpandMax ));
                list.Add("autoExpandMin", new ConfigOption("autoExpandMin", null, Unit.Pixel(50), this.AutoExpandMin ));
                list.Add("columns", new ConfigOption("columns", new SerializationOptions("columns", JsonMode.AlwaysArray), null, this.Columns ));
                list.Add("rootVisible", new ConfigOption("rootVisible", null, false, this.RootVisible ));
                list.Add("useArrows", new ConfigOption("useArrows", null, true, this.UseArrows ));
                list.Add("lines", new ConfigOption("lines", null, false, this.Lines ));
                list.Add("columnResize", new ConfigOption("columnResize", null, true, this.ColumnResize ));
                list.Add("enableSort", new ConfigOption("enableSort", null, true, this.EnableSort ));
                list.Add("reserveScrollOffset", new ConfigOption("reserveScrollOffset", null, true, this.ReserveScrollOffset ));
                list.Add("enableHdMenu", new ConfigOption("enableHdMenu", null, true, this.EnableHdMenu ));
                list.Add("columnsText", new ConfigOption("columnsText", null, "Columns", this.ColumnsText ));
                list.Add("hideHeaders", new ConfigOption("hideHeaders", null, false, this.HideHeaders ));

                return list;
            }
        }
    }
}