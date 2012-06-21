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
    public partial class DataFilter
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
                
                list.Add("anyMatch", new ConfigOption("anyMatch", null, false, this.AnyMatch ));
                list.Add("caseSensitive", new ConfigOption("caseSensitive", null, false, this.CaseSensitive ));
                list.Add("exactMatch", new ConfigOption("exactMatch", null, false, this.ExactMatch ));
                list.Add("filterFn", new ConfigOption("filterFn", new SerializationOptions(JsonMode.Raw), null, this.FilterFn ));
                list.Add("property", new ConfigOption("property", null, "", this.Property ));
                list.Add("root", new ConfigOption("root", null, "", this.Root ));
                list.Add("value", new ConfigOption("value", null, null, this.Value ));

                return list;
            }
        }
    }
}