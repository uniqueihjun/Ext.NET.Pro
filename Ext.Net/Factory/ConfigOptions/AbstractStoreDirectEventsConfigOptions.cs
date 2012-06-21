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
    public partial class AbstractStoreDirectEvents
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
                
                list.Add("add", new ConfigOption("add", new SerializationOptions("add", typeof(DirectEventJsonConverter)), null, this.Add ));
                list.Add("beforeLoad", new ConfigOption("beforeLoad", new SerializationOptions("beforeload", typeof(DirectEventJsonConverter)), null, this.BeforeLoad ));
                list.Add("beforeSync", new ConfigOption("beforeSync", new SerializationOptions("beforesync", typeof(DirectEventJsonConverter)), null, this.BeforeSync ));
                list.Add("clear", new ConfigOption("clear", new SerializationOptions("clear", typeof(DirectEventJsonConverter)), null, this.Clear ));
                list.Add("dataChanged", new ConfigOption("dataChanged", new SerializationOptions("datachanged", typeof(DirectEventJsonConverter)), null, this.DataChanged ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(DirectEventJsonConverter)), null, this.Load ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(DirectEventJsonConverter)), null, this.Remove ));
                list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(DirectEventJsonConverter)), null, this.Update ));
                list.Add("write", new ConfigOption("write", new SerializationOptions("write", typeof(DirectEventJsonConverter)), null, this.Write ));
                list.Add("exception", new ConfigOption("exception", new SerializationOptions("exception", typeof(DirectEventJsonConverter)), null, this.Exception ));
                list.Add("metaChange", new ConfigOption("metaChange", new SerializationOptions("metachange", typeof(DirectEventJsonConverter)), null, this.MetaChange ));
                list.Add("refresh", new ConfigOption("refresh", new SerializationOptions("refresh", typeof(DirectEventJsonConverter)), null, this.Refresh ));

                return list;
            }
        }
    }
}