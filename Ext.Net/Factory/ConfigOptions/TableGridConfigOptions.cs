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
    public partial class TableGrid
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
                
                list.Add("renderToProxy", new ConfigOption("renderToProxy", new SerializationOptions(JsonMode.Ignore), null, this.RenderToProxy ));
                list.Add("tableProxy", new ConfigOption("tableProxy", new SerializationOptions("table", JsonMode.Raw), null, this.TableProxy ));
                list.Add("columnModel", new ConfigOption("columnModel", new SerializationOptions(JsonMode.Ignore), null, this.ColumnModel ));
                list.Add("columns", new ConfigOption("columns", new SerializationOptions("columns", JsonMode.AlwaysArray), null, this.Columns ));
                list.Add("fields", new ConfigOption("fields", new SerializationOptions("fields", JsonMode.AlwaysArray), null, this.Fields ));
                list.Add("autoHeight", new ConfigOption("autoHeight", null, true, this.AutoHeight ));

                return list;
            }
        }
    }
}