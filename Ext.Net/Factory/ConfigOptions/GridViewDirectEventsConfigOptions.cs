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
    public partial class GridViewDirectEvents
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
                
                list.Add("beforeRefresh", new ConfigOption("beforeRefresh", new SerializationOptions("beforerefresh", typeof(DirectEventJsonConverter)), null, this.BeforeRefresh ));
                list.Add("beforeRowRemoved", new ConfigOption("beforeRowRemoved", new SerializationOptions("beforerowremoved", typeof(DirectEventJsonConverter)), null, this.BeforeRowRemoved ));
                list.Add("beforeRowsInserted", new ConfigOption("beforeRowsInserted", new SerializationOptions("beforerowsinserted", typeof(DirectEventJsonConverter)), null, this.BeforeRowsInserted ));
                list.Add("refresh", new ConfigOption("refresh", new SerializationOptions("refresh", typeof(DirectEventJsonConverter)), null, this.Refresh ));
                list.Add("rowRemoved", new ConfigOption("rowRemoved", new SerializationOptions("rowremoved", typeof(DirectEventJsonConverter)), null, this.RowRemoved ));
                list.Add("rowsInserted", new ConfigOption("rowsInserted", new SerializationOptions("rowsinserted", typeof(DirectEventJsonConverter)), null, this.RowsInserted ));
                list.Add("rowUpdated", new ConfigOption("rowUpdated", new SerializationOptions("rowupdated", typeof(DirectEventJsonConverter)), null, this.RowUpdated ));

                return list;
            }
        }
    }
}