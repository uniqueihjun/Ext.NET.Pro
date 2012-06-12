/********
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class StoreDirectEvents
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
                list.Add("clear", new ConfigOption("clear", new SerializationOptions("clear", typeof(DirectEventJsonConverter)), null, this.Clear ));
                list.Add("dataChanged", new ConfigOption("dataChanged", new SerializationOptions("datachanged", typeof(DirectEventJsonConverter)), null, this.DataChanged ));
                list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(DirectEventJsonConverter)), null, this.Load ));
                list.Add("loadException", new ConfigOption("loadException", new SerializationOptions("loadexception", typeof(DirectEventJsonConverter)), null, this.LoadException ));
                list.Add("metaChange", new ConfigOption("metaChange", new SerializationOptions("metachange", typeof(DirectEventJsonConverter)), null, this.MetaChange ));
                list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(DirectEventJsonConverter)), null, this.Remove ));
                list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(DirectEventJsonConverter)), null, this.Update ));
                list.Add("beforeSave", new ConfigOption("beforeSave", new SerializationOptions("beforesave", typeof(DirectEventJsonConverter)), null, this.BeforeSave ));
                list.Add("save", new ConfigOption("save", new SerializationOptions("save", typeof(DirectEventJsonConverter)), null, this.Save ));
                list.Add("saveException", new ConfigOption("saveException", new SerializationOptions("saveexception", typeof(DirectEventJsonConverter)), null, this.SaveException ));
                list.Add("commitDone", new ConfigOption("commitDone", new SerializationOptions("commitdone", typeof(DirectEventJsonConverter)), null, this.CommitDone ));
                list.Add("commitFailed", new ConfigOption("commitFailed", new SerializationOptions("commitfailed", typeof(DirectEventJsonConverter)), null, this.CommitFailed ));
                list.Add("exception", new ConfigOption("exception", new SerializationOptions("exception", typeof(DirectEventJsonConverter)), null, this.Exception ));
                list.Add("groupChange", new ConfigOption("groupChange", new SerializationOptions("groupchange", typeof(DirectEventJsonConverter)), null, this.GroupChange ));

                return list;
            }
        }
    }
}