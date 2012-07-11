/********
 * @version   : 2.0.0.rc2 - Ext.NET Pro License
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
    /// <summary>
    /// 
    /// </summary>
    public partial class DropZone
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
                
                list.Add("getTargetFromEvent", new ConfigOption("getTargetFromEvent", new SerializationOptions(JsonMode.Raw), null, this.GetTargetFromEvent ));
                list.Add("onContainerDrop", new ConfigOption("onContainerDrop", new SerializationOptions(JsonMode.Raw), null, this.OnContainerDrop ));
                list.Add("onContainerOver", new ConfigOption("onContainerOver", new SerializationOptions(JsonMode.Raw), null, this.OnContainerOver ));
                list.Add("onNodeDrop", new ConfigOption("onNodeDrop", new SerializationOptions(JsonMode.Raw), null, this.OnNodeDrop ));
                list.Add("onNodeEnter", new ConfigOption("onNodeEnter", new SerializationOptions(JsonMode.Raw), null, this.OnNodeEnter ));
                list.Add("onNodeOut", new ConfigOption("onNodeOut", new SerializationOptions(JsonMode.Raw), null, this.OnNodeOut ));
                list.Add("onNodeOver", new ConfigOption("onNodeOver", new SerializationOptions(JsonMode.Raw), null, this.OnNodeOver ));

                return list;
            }
        }
    }
}