/********
 * @version   : 2.0.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
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
    public partial class DragTrackerDirectEvents
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
                
                list.Add("beforeStart", new ConfigOption("beforeStart", new SerializationOptions("beforestart", typeof(DirectEventJsonConverter)), null, this.BeforeStart ));
                list.Add("drag", new ConfigOption("drag", new SerializationOptions("drag", typeof(DirectEventJsonConverter)), null, this.Drag ));
                list.Add("dragEnd", new ConfigOption("dragEnd", new SerializationOptions("dragend", typeof(DirectEventJsonConverter)), null, this.DragEnd ));
                list.Add("dragStart", new ConfigOption("dragStart", new SerializationOptions("dragstart", typeof(DirectEventJsonConverter)), null, this.DragStart ));
                list.Add("mouseDown", new ConfigOption("mouseDown", new SerializationOptions("mousedown", typeof(DirectEventJsonConverter)), null, this.MouseDown ));
                list.Add("mouseMove", new ConfigOption("mouseMove", new SerializationOptions("mousemove", typeof(DirectEventJsonConverter)), null, this.MouseMove ));
                list.Add("mouseUp", new ConfigOption("mouseUp", new SerializationOptions("mouseup", typeof(DirectEventJsonConverter)), null, this.MouseUp ));
                list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseout", typeof(DirectEventJsonConverter)), null, this.MouseOut ));
                list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseover", typeof(DirectEventJsonConverter)), null, this.MouseOver ));

                return list;
            }
        }
    }
}