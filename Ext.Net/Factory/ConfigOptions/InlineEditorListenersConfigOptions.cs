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
    public partial class InlineEditorListeners
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
                
                list.Add("beforeStartEdit", new ConfigOption("beforeStartEdit", new SerializationOptions("beforestartedit", typeof(ListenerJsonConverter)), null, this.BeforeStartEdit ));
                list.Add("beforeComplete", new ConfigOption("beforeComplete", new SerializationOptions("beforecomplete", typeof(ListenerJsonConverter)), null, this.BeforeComplete ));
                list.Add("cancelEdit", new ConfigOption("cancelEdit", new SerializationOptions("canceledit", typeof(ListenerJsonConverter)), null, this.CancelEdit ));
                list.Add("complete", new ConfigOption("complete", new SerializationOptions("complete", typeof(ListenerJsonConverter)), null, this.Complete ));
                list.Add("specialKey", new ConfigOption("specialKey", new SerializationOptions("specialkey", typeof(ListenerJsonConverter)), null, this.SpecialKey ));
                list.Add("startEdit", new ConfigOption("startEdit", new SerializationOptions("startedit", typeof(ListenerJsonConverter)), null, this.StartEdit ));

                return list;
            }
        }
    }
}