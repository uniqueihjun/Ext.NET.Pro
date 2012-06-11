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
    public partial class InlineEditorDirectEvents
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
                
                list.Add("beforeStartEdit", new ConfigOption("beforeStartEdit", new SerializationOptions("beforestartedit", typeof(DirectEventJsonConverter)), null, this.BeforeStartEdit ));
                list.Add("beforeComplete", new ConfigOption("beforeComplete", new SerializationOptions("beforecomplete", typeof(DirectEventJsonConverter)), null, this.BeforeComplete ));
                list.Add("cancelEdit", new ConfigOption("cancelEdit", new SerializationOptions("canceledit", typeof(DirectEventJsonConverter)), null, this.CancelEdit ));
                list.Add("complete", new ConfigOption("complete", new SerializationOptions("complete", typeof(DirectEventJsonConverter)), null, this.Complete ));
                list.Add("specialKey", new ConfigOption("specialKey", new SerializationOptions("specialkey", typeof(DirectEventJsonConverter)), null, this.SpecialKey ));
                list.Add("startEdit", new ConfigOption("startEdit", new SerializationOptions("startedit", typeof(DirectEventJsonConverter)), null, this.StartEdit ));

                return list;
            }
        }
    }
}