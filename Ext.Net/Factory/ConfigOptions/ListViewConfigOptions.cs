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
    public partial class ListView
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
                
                list.Add("columnResizeProxy", new ConfigOption("columnResizeProxy", new SerializationOptions("columnResize", JsonMode.Raw), "", this.ColumnResizeProxy ));
                list.Add("columnSort", new ConfigOption("columnSort", null, true, this.ColumnSort ));
                list.Add("columns", new ConfigOption("columns", new SerializationOptions("columns", JsonMode.AlwaysArray), null, this.Columns ));
                list.Add("hideHeaders", new ConfigOption("hideHeaders", null, false, this.HideHeaders ));
                list.Add("reserveScrollOffset", new ConfigOption("reserveScrollOffset", null, false, this.ReserveScrollOffset ));
                list.Add("disableHeaders", new ConfigOption("disableHeaders", null, false, this.DisableHeaders ));

                return list;
            }
        }
    }
}