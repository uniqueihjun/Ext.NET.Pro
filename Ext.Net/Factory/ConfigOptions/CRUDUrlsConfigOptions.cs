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
    public partial class CRUDUrls
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
                
                list.Add("syncProxy", new ConfigOption("syncProxy", new SerializationOptions("sync", JsonMode.Raw), "", this.SyncProxy ));
                list.Add("createProxy", new ConfigOption("createProxy", new SerializationOptions("create", JsonMode.Raw), "", this.CreateProxy ));
                list.Add("readProxy", new ConfigOption("readProxy", new SerializationOptions("read", JsonMode.Raw), "", this.ReadProxy ));
                list.Add("updateProxy", new ConfigOption("updateProxy", new SerializationOptions("update", JsonMode.Raw), "", this.UpdateProxy ));
                list.Add("destroyProxy", new ConfigOption("destroyProxy", new SerializationOptions("destroy", JsonMode.Raw), "", this.DestroyProxy ));

                return list;
            }
        }
    }
}