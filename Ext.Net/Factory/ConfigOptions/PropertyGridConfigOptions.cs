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
    public partial class PropertyGrid
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
                
                list.Add("source", new ConfigOption("source", new SerializationOptions(JsonMode.ArrayToObject), null, this.Source ));
                list.Add("customEditors", new ConfigOption("customEditors", new SerializationOptions(JsonMode.Raw), null, this.CustomEditors ));
                list.Add("customRenderers", new ConfigOption("customRenderers", new SerializationOptions(JsonMode.Raw), null, this.CustomRenderers ));
                list.Add("propertyNames", new ConfigOption("propertyNames", new SerializationOptions(JsonMode.Raw), null, this.PropertyNames ));
                list.Add("editable", new ConfigOption("editable", null, true, this.Editable ));
                list.Add("directEventConfig", new ConfigOption("directEventConfig", new SerializationOptions(JsonMode.Object), null, this.DirectEventConfig ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}