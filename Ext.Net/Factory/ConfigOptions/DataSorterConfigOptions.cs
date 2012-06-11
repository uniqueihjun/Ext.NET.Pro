/********
 * @version   : 2.0.0.beta3 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
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
    public partial class DataSorter
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
                
                list.Add("direction", new ConfigOption("direction", null, SortDirection.Default, this.Direction ));
                list.Add("property", new ConfigOption("property", null, "", this.Property ));
                list.Add("root", new ConfigOption("root", null, "", this.Root ));
                list.Add("sorterFn", new ConfigOption("sorterFn", new SerializationOptions(JsonMode.Raw), null, this.SorterFn ));
                list.Add("transform", new ConfigOption("transform", new SerializationOptions(JsonMode.Raw), null, this.Transform ));

                return list;
            }
        }
    }
}