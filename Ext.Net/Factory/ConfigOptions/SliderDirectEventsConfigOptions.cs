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
    public partial class SliderDirectEvents
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
                
                list.Add("beforeChange", new ConfigOption("beforeChange", new SerializationOptions("beforechange", typeof(DirectEventJsonConverter)), null, this.BeforeChange ));
                list.Add("change", new ConfigOption("change", new SerializationOptions("change", typeof(DirectEventJsonConverter)), null, this.Change ));
                list.Add("changeComplete", new ConfigOption("changeComplete", new SerializationOptions("changecomplete", typeof(DirectEventJsonConverter)), null, this.ChangeComplete ));
                list.Add("drag", new ConfigOption("drag", new SerializationOptions("drag", typeof(DirectEventJsonConverter)), null, this.Drag ));
                list.Add("dragEnd", new ConfigOption("dragEnd", new SerializationOptions("dragend", typeof(DirectEventJsonConverter)), null, this.DragEnd ));
                list.Add("dragStart", new ConfigOption("dragStart", new SerializationOptions("dragstart", typeof(DirectEventJsonConverter)), null, this.DragStart ));

                return list;
            }
        }
    }
}