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
    public abstract partial class AbstractDrawComponent
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
                
                list.Add("autoSize", new ConfigOption("autoSize", null, false, this.AutoSize ));
                list.Add("enginePriority", new ConfigOption("enginePriority", new SerializationOptions(typeof(StringArrayJsonConverter)), null, this.EnginePriority ));
                list.Add("gradients", new ConfigOption("gradients", new SerializationOptions(JsonMode.AlwaysArray), null, this.Gradients ));
                list.Add("viewBox", new ConfigOption("viewBox", null, true, this.ViewBox ));
                list.Add("background", new ConfigOption("background", new SerializationOptions(JsonMode.Object), null, this.Background ));
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", JsonMode.AlwaysArray), null, this.Items ));

                return list;
            }
        }
    }
}