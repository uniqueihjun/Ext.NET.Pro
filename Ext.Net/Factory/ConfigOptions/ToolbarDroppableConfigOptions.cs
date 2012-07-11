/********
 * @version   : 1.5.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-10
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
    public partial class ToolbarDroppable
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
                
                list.Add("configIDProxy", new ConfigOption("configIDProxy", new SerializationOptions("proxyId"), null, this.ConfigIDProxy ));
                list.Add("createItem", new ConfigOption("createItem", new SerializationOptions(JsonMode.Raw), null, this.CreateItem ));
                list.Add("canDrop", new ConfigOption("canDrop", new SerializationOptions(JsonMode.Raw), null, this.CanDrop ));
                list.Add("calculateEntryIndex", new ConfigOption("calculateEntryIndex", new SerializationOptions(JsonMode.Raw), null, this.CalculateEntryIndex ));
                list.Add("directEventConfig", new ConfigOption("directEventConfig", new SerializationOptions(JsonMode.Object), null, this.DirectEventConfig ));
                list.Add("mode", new ConfigOption("mode", new SerializationOptions(JsonMode.ToLower), DataLoadMode.Local, this.Mode ));
                list.Add("beforeRemoteCreate", new ConfigOption("beforeRemoteCreate", new SerializationOptions(JsonMode.Raw), null, this.BeforeRemoteCreate ));
                list.Add("afterRemoteCreate", new ConfigOption("afterRemoteCreate", new SerializationOptions(JsonMode.Raw), null, this.AfterRemoteCreate ));

                return list;
            }
        }
    }
}