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
    public partial class DragTrackerListeners
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
                
                list.Add("drag", new ConfigOption("drag", new SerializationOptions("drag", typeof(ListenerJsonConverter)), null, this.Drag ));
                list.Add("dragEnd", new ConfigOption("dragEnd", new SerializationOptions("dragend", typeof(ListenerJsonConverter)), null, this.DragEnd ));
                list.Add("dragStart", new ConfigOption("dragStart", new SerializationOptions("dragstart", typeof(ListenerJsonConverter)), null, this.DragStart ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(ListenerJsonConverter)), null, this.MouseDown ));
                list.Add("mouseMove", new ConfigOption("mouseMove", new SerializationOptions("mousemove", typeof(ListenerJsonConverter)), null, this.MouseMove ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(ListenerJsonConverter)), null, this.MouseUp ));

                return list;
            }
        }
    }
}